namespace CSharpGenerator
{
    /// <summary>
    /// A summary comment generator.
    /// </summary>
    public sealed class Summary : Comment
    {
        /* Casting operators. */
        public static implicit operator Summary(string text)
        {
            return new() { Text = text };
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