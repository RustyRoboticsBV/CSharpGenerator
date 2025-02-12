namespace CSharpGenerator
{
    /// <summary>
    /// An argument generator.
    /// </summary>
    public sealed class Argument : Generator
    {
        /* Public properties. */
        public string Value { get; set; } = "";

        /* Casting operators. */
        public static implicit operator Argument(string value)
        {
            return new()
            {
                Value = value
            };
        }

        /* Public methods. */
        public override string Generate()
        {
            return Value;
        }
    }
}