namespace CSharpGenerator
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
        public StructInheritance Inheritance { get; set; } = new();
        public InterfaceMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            Block contents = new Block()
            {
                Contents = Members
            };
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}interface {Name} "
                + $"{Inheritance.Generate()}\n{contents.Generate()}";
        }
    }
}
