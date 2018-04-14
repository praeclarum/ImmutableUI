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

        public TypeDefinition GetType(string name) =>
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

                Parallel.ForEach (bindings.Types, x => BindType (x, bindings));

                var code = String.Join ("\n\n", bindings.Types.Select(x => x.BoundCode));

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
                var t = bindings.GetType (type.Name);
                type.Definition = t;

                foreach (var m in type.Members) {
                    if (FindProperty (m.Name, t) is PropertyDefinition p) {
                        m.Definition = p;
                        BindProperty (m, type);
                    }
                    else if (FindEvent (m.Name, t) is EventDefinition e) {
                        m.Definition = e;
                        BindProperty (m, type);
                    }
                    else {
                        throw new Exception ($"Could not find member `{m.Name}`");
                    }
                }
                
                type.BoundCode = t.Name + " " + t.Properties.Count;
            }
            catch (Exception ex) {
                type.BoundCode = "/* " + ex + " */";
            }
        }

        static void BindProperty(MemberBinding m, TypeBinding t)
        {
            var p = (PropertyDefinition)m.Definition;

            throw new NotImplementedException();
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
