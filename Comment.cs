namespace CSharpGenerator
{
    /// <summary>
    /// A base class for comment generators.
    /// </summary>
    public abstract class Comment : Generator
    {
        /* Public properties. */
        public string Text { get; set; }

        /* Constructors. */
        public Comment() : this("") { }

        public Comment(string text)
        {
            Text = text ?? "";
        }

        /* Conversion operators. */
        public static implicit operator string(Comment comment)
        {
            return comment.Text;
        }
    }
}