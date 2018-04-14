using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Mono.Cecil;
using Newtonsoft.Json;

namespace Generator
{
    class Bindings
    {
        // Input
        public List<string> Assemblies { get; set; }
        public List<TypeBinding> Types { get; set; }

        // Output
        public List<AssemblyDefinition> AssemblyDefinitions { get; set; }

        public TypeDefinition GetTypeDefinition(string name) =>
            (from a in AssemblyDefinitions
             from m in a.Modules
             from t in m.Types
             where t.FullName == name
             select t).First();
    }

    class TypeBinding
    {
        // Input
        public string Name { get; set; }
        public List<MemberBinding> Members { get; set; }

        // Output
        public string BoundCode { get; set; }
        public TypeDefinition Definition { get; set; }
    }

    class MemberBinding
    {
        // Input
        public string Name { get; set; }

        // Output
        public MemberReference Definition { get; set; }

        public TypeReference BoundType =>
            (Definition is PropertyDefinition p) ?
                p.PropertyType : 
                ((EventDefinition)Definition).EventType;

        public string LowerName => char.ToLowerInvariant (Name[0]) + Name.Substring (1);
    }

    class Program
    {
        static int Main(string[] args)
        {
            try {
                var bindingsPath = args[0];
                var outputPath = args[1];

                var bindings = JsonConvert.DeserializeObject<Bindings> (File.ReadAllText (args[0]));

                bindings.AssemblyDefinitions = bindings.Assemblies.Select(LoadAssembly).ToList();

                foreach (var x in bindings.Types)
                    x.Definition = bindings.GetTypeDefinition (x.Name);
                foreach (var x in bindings.Types)
                    BindType (x, bindings);

                var code = String.Join ("\n", bindings.Types.Select(x => x.BoundCode));

                File.WriteAllText (outputPath, code);
                return 0;
            }
            catch (Exception ex) {
                System.Console.WriteLine(ex);
                return 1;
            }
        }

        static void BindType (TypeBinding type, Bindings bindings)
        {
            try {
                var t = type.Definition;
                var h = GetHierarchy (type.Definition);
                var bh = h.Select (x => bindings.Types.FirstOrDefault(y => y.Name == x.FullName))
                          .Where (x => x != null)
                          .ToList ();

                foreach (var m in type.Members) {
                    if (FindProperty (m.Name, t) is PropertyDefinition p) {
                        m.Definition = p;
                    }
                    else if (FindEvent (m.Name, t) is EventDefinition e) {
                        m.Definition = e;
                    }
                    else {
                        throw new Exception ($"Could not find member `{m.Name}`");
                    }
                }

                var w = new StringWriter ();
                w.Write ($"public partial class {t.Name}");
                var baseType = bh.Count > 1 ? bh[1] : null;
                if (baseType != null)
                    w.WriteLine ($" : {baseType.Definition.Name}");
                else
                    w.WriteLine ();
                w.WriteLine ("{");

                var allmembers = (from x in bh from y in x.Members select y).ToList ();

                foreach (var m in type.Members) {
                    w.WriteLine ($"\tpublic {Name(m.BoundType)} {m.Name} {{ get; }}");
                }

                w.Write ($"\tpublic {t.Name}(");
                var head = "";
                foreach (var m in allmembers) {
                    w.Write ($"{head}{Name(m.BoundType)} {m.LowerName}");
                    head = ", ";
                }
                w.Write($")");
                if (baseType != null) {
                    w.WriteLine();
                    w.Write("\t\t: base(");
                    head = "";
                    foreach (var m in baseType.Members) {
                        w.Write ($"{head}{m.LowerName}");
                        head = ", ";
                    }
                    w.Write($")");
                }
                w.WriteLine(" {");
                w.WriteLine ("\t}");

                w.WriteLine ("}");
                
                type.BoundCode = w.ToString ();
            }
            catch (Exception ex) {
                type.BoundCode = "/* " + ex + " */";
            }
        }

        static string Name (TypeReference t)
        {
            switch (t.FullName) {
                case "System.String": return "string";
                case "System.Int32": return "int";
                default: return t.FullName;
            }
        }

        static PropertyDefinition FindProperty(string name, TypeDefinition type)
        {
            var q =
                from t in GetHierarchy(type)
                from p in t.Properties
                where p.Name == name
                select p;
            return q.FirstOrDefault ();
        }

        static EventDefinition FindEvent(string name, TypeDefinition type)
        {
            var q =
                from t in GetHierarchy(type)
                from p in t.Events
                where p.Name == name
                select p;
            return q.FirstOrDefault ();
        }

        static IEnumerable<TypeDefinition> GetHierarchy (TypeDefinition type)
        {
            var d = type;
            yield return d;
            while (d.BaseType != null) {
                d = d.BaseType.Resolve();
                yield return d;
            }
        }

        static AssemblyDefinition LoadAssembly (string path)
        {
            if (path.StartsWith("packages")) {
                var user = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine (user, ".nuget", path);
            }
            return AssemblyDefinition.ReadAssembly(path);
        }
    }
}
