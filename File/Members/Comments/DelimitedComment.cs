namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A delimited comment generator.
    /// </summary>
    public class DelimitedComment : Comment
    {
        /* Constructors. */
        public DelimitedComment() : base() { }

        public DelimitedComment(DelimitedComment other) : base(other) { }

        public DelimitedComment(string text) : base(text) { }

        /* Casting operators. */
        public static implicit operator DelimitedComment(string text)
        {
            return new() { Text = text };
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new DelimitedComment(this);
        }

        public override string Generate()
        {
            if (Text == "")
                return "";
            else
            {
                string text = Text.Replace("\n", "\n   ");
                if (text.EndsWith("\n   "))
                    text = text.Substring(0, text.Length - 4);
                return $"/* {text} */";
            }
        }
    }
}