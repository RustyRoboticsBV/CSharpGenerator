namespace CSharpGenerator
{
    /// <summary>
    /// An enum generator.
    /// </summary>
    public class Enum : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string Name { get; set; } = "";
        public EnumInheritance Inheritance { get; set; } = new();
        public EnumMemberList Members { get; set; } = new();

        /* Constructors. */
        public Enum() { }

        public Enum(Enum other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Name = other.Name;
            Inheritance = new(other.Inheritance);
            Members = new(other.Members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Enum(this);
        }

        public override string Generate()
        {
            Block contents = new Block()
            {
                Contents = Members
            };
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}"
                + $"enum {Name}{Inheritance.Generate()}\n{contents.Generate()}";
        }
    }
}
