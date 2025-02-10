namespace CSharpGenerator
{
    /// <summary>
    /// A delimited comment generator.
    /// </summary>
    public sealed class DelimitedComment : Comment
    {
        /* Constructors. */
        public DelimitedComment() : this(null) { }

        public DelimitedComment(string text) : base(text) { }

        /* Conversion operators. */
        public static implicit operator DelimitedComment(string text)
        {
            return new(text);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Text == "")
                return "";
            else
                return $"/* {Text.Replace("\n", "\n   ")} */";
        }
    }
}