namespace CSharpGenerator
{
    /// <summary>
    /// A summary comment generator.
    /// </summary>
    public class Summary : Comment
    {
        /* Constructors. */
        public Summary() { }

        public Summary(Summary other)
        {
            Text = other.Text;
        }

        public Summary(string text)
        {
            Text = text;
        }

        /* Casting operators. */
        public static implicit operator Summary(string text)
        {
            return new(text);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Summary(this);
        }

        public override string Generate()
        {
            if (Text == "")
                return "";
            else
                return $"/// <summary>\n/// {Text.Replace("\n", "\n/// ")}\n/// </summary>";
        }
    }
}