namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A struct generator.
    /// </summary>
    public class Struct : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public StructModifier Modifier { get; set; } = StructModifierID.None;
        public string Name { get; set; } = "";
        public GenericParameterList GenericParameters { get; set; } = new();
        public InterfaceList Inheritance { get; set; } = new();
        public GenericConstraintList GenericConstraints { get; set; } = new();
        public StructMemberList Members { get; set; } = new();

        /* Constructors. */
        public Struct() { }

        public Struct(Struct other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Modifier = new(other.Modifier);
            Name = other.Name;
            GenericParameters = new(other.GenericParameters);
            Inheritance = new(other.Inheritance);
            GenericConstraints = new(other.GenericConstraints);
            Members = new(other.Members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Struct(this);
        }

        public override string Generate()
        {
            Block contents = new Block(Members);
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifier.Generate(" ")}"
                + $"struct {Name}{GenericParameters.Generate()}{Inheritance.Generate()}{GenericConstraints.Generate()}"
                + $"\n{contents.Generate()}";
        }
    }
}