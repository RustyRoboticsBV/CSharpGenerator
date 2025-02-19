namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A base class for comment generators.
    /// </summary>
    public abstract class Comment : Generator,
        IFileMember, INamespaceMember, IClassMember, IStructMember, IInterfaceMember, IEnumMember
    {
        /* Public properties. */
        public string Text { get; set; } = "";

        /* Constructors. */
        public Comment() { }

        public Comment(Comment other)
        {
            Text = other.Text;
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}