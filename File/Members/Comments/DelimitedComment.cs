namespace CSharpGenerator
{
    /// <summary>
    /// A delimited comment generator.
    /// </summary>
    public sealed class DelimitedComment : Comment
    {
        /* Casting operators. */
        public static implicit operator DelimitedComment(string text)
        {
            return new() { Text = text };
        }

        /* Public methods. */
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