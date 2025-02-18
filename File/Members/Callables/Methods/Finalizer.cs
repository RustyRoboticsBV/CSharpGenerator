namespace CSharpGenerator
{
    /// <summary>
    /// A destructor generator.
    /// </summary>
    public class Finalizer : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public string TypeName { get; set; } = "Name";
        public MethodImplementation Implementation { get; set; } = "";

        /* Constructors. */
        public Finalizer() { }

        public Finalizer(Finalizer other)
        {
            Summary = new(other.Summary);
            TypeName = other.TypeName;
            Implementation = new(other.Implementation);
        }

        public Finalizer(Summary summary, string typeName, MethodImplementation implementation)
        {
            Summary = summary;
            TypeName = typeName;
            Implementation = implementation;
        }

        public Finalizer(string typeName, MethodImplementation implementation)
        {
            TypeName = typeName;
            Implementation = implementation;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Finalizer(this);
        }

        public override string Generate()
        {
            return $"{Summary.Generate("\n")}~{TypeName}()\n{Implementation.Generate()}";
        }
    }
}