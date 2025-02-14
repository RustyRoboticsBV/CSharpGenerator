namespace CSharpGenerator
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
        public StructInheritance Inheritance { get; set; } = new();
        public StructMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            Block contents = new Block()
            {
                Contents = Members
            };
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifier.Generate(" ")}"
                + $"{Name}{Inheritance.Generate()}\n{contents.Generate()}";
        }
    }
}