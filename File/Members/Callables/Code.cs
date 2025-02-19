namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A code generator.
    /// </summary>
    public class Code : Generator
    {
        /* Public properties. */
        public string Text { get; set; } = "";

        /* Constructors. */
        public Code() { }

        public Code(Code other)
        {
            Text = other.Text;
        }

        public Code(string text)
        {
            Text = text;
        }

        /* Casting operators. */
        public static implicit operator Code(string text)
        {
            return new()
            {
                Text = text
            };
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Code(this);
        }

        public override string Generate()
        {
            return Text;
        }
    }
}