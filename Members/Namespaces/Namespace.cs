namespace CSharpGenerator
{
    /// <summary>
    /// A namespace generator.
    /// </summary>
    public class Namespace : Generator, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public string Name { get; set; } = "";
        public NamespaceMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            Block contents = new Block()
            {
                Contents = Members
            };
            return $"namespace {Name}\n{contents.Generate()}";
        }
    }
}