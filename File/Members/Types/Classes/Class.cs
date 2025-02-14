namespace CSharpGenerator
{
    /// <summary>
    /// A class generator.
    /// </summary>
    public class Class : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public ClassModifier Modifier { get; set; } = ClassModifierID.None;
        public string Name { get; set; } = "";
        public ClassInheritance Inheritance { get; set; } = new();
        public ClassMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            Block contents = new Block()
            {
                Contents = Members
            };
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifier.Generate(" ")}"
                + $"class {Name}{Inheritance.Generate()}\n{contents.Generate()}";
        }
    }
}
