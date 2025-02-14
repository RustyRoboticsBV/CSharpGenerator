namespace CSharpGenerator
{
    /// <summary>
    /// A code generator.
    /// </summary>
    public class Code : Generator
    {
        /* Public properties. */
        public string Text { get; set; } = "";

        /* Casting operators. */
        public static implicit operator Code(string text)
        {
            return new()
            {
                Text = text
            };
        }

        /* Public methods. */
        public override string Generate()
        {
            return Text;
        }
    }
}