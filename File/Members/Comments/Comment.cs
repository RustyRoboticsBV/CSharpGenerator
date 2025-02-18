namespace CSharpGenerator
{
    /// <summary>
    /// A base class for comment generators.
    /// </summary>
    public abstract class Comment : Generator
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