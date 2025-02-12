namespace CSharpGenerator
{
    /// <summary>
    /// An enum generator.
    /// </summary>
    public class Enum : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessKeywordID.Public;
        public string Name { get; set; } = "";
        public EnumInheritance Inheritance { get; set; } = new();
        public EnumMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            Block contents = new Block()
            {
                Contents = Members
            };
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}"
                + $"{Name}{Inheritance.Generate()}\n{contents.Generate()}";
        }
    }
}
