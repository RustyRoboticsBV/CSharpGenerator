namespace CSharpGenerator
{
    /// <summary>
    /// A code block generator.
    /// </summary>
    public sealed class Summary : Generator
    {
        /* Public properties. */
        public string Text { get; private set; }

        /* Constructors. */
        public Summary() : this("") { }

        public Summary(string text)
        {
            if (text == null)
                text = "";
            Text = text;
        }

        /* Conversion operators. */
        public static implicit operator Summary(string text)
        {
            return new(text);
        }

        public static implicit operator string(Summary summary)
        {
            return summary.Text;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Text == "")
                return "";
            else
                return $"/// <summary>\n/// {Text.Replace("\n", "\n/// ")}\n/// </summary>";
        }
    }
}
