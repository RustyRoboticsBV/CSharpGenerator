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

        /* Constructors. */
        public Namespace() { }

        public Namespace(Namespace other)
        {
            Name = other.Name;
            Members = new(other.Members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Namespace(this);
        }

        public override string Generate()
        {
            Block contents = new(Members);
            return $"namespace {Name}\n{contents.Generate()}";
        }
    }
}