namespace CSharpGenerator
{
    /// <summary>
    /// A delegate generator.
    /// </summary>
    public class Delegate : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string ReturnType { get; set; } = "void";
        public string Name { get; set; } = "Name";
        public GenericParameterList GenericParameters { get; set; } = new();
        public ParameterList Parameters { get; set; } = new();
        public GenericConstraintList GenericConstraints { get; set; } = new();

        /* Constructors. */
        public Delegate() { }

        public Delegate(Delegate other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            ReturnType = other.ReturnType;
            Name = other.Name;
            GenericParameters = new(other.GenericParameters);
            Parameters = new(other.Parameters);
            GenericConstraints = new(other.GenericConstraints);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Delegate(this);
        }

        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}delegate {ReturnType} {Name}"
                + $"{GenericParameters.Generate()}({Parameters.Generate()}){GenericConstraints.Generate()};";
        }
    }
}