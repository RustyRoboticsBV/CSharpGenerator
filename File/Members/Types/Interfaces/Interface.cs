namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A interface generator.
    /// </summary>
    public class Interface : Generator, IClassMember, IStructMember, IInterfaceMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string Name { get; set; } = "";
        public GenericParameterList GenericParameters { get; set; } = new();
        public InterfaceList Inheritance { get; set; } = new();
        public GenericConstraintList GenericConstraints { get; set; } = new();
        public InterfaceMemberList Members { get; set; } = new();

        /* Constructors. */
        public Interface() { }

        public Interface(Interface other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Name = other.Name;
            GenericParameters = new(other.GenericParameters);
            Inheritance = new(other.Inheritance);
            Members = new(other.Members);
            GenericConstraints = new(other.GenericConstraints);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Interface(this);
        }

        public override string Generate()
        {
            Block contents = new Block(Members);
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}interface {Name}"
                + $"{GenericParameters.Generate()}{Inheritance.Generate()}{GenericConstraints.Generate()}"
                + $"\n{contents.Generate()}";
        }
    }
}
