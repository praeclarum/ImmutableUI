
GEN_SRC=Generator/Program.cs
GEN=dotnet run --project Generator/Generator.csproj

all: ImmutableUI.Forms/bin/Debug/netstandard2.0/ImmutableUI.Forms.dll

ImmutableUI.Forms/ImmutableUI.Forms.Generated.cs: Makefile $(GEN_SRC) ImmutableUI.Forms/bindings.json
	$(GEN) ImmutableUI.Forms/bindings.json $@

ImmutableUI.Forms/bin/Debug/netstandard2.0/ImmutableUI.Forms.dll: ImmutableUI.Forms/ImmutableUI.Forms.Generated.cs
	msbuild ImmutableUI.Forms/ImmutableUI.Forms.csproj
