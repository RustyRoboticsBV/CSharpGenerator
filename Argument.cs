namespace CSharpGenerator
{
    /// <summary>
    /// An argument generator.
    /// </summary>
    public sealed class Argument : Generator
    {
        /* Public properties. */
        public string Value { get; private set; }

        /* Constructors. */
        public Argument() : this("") { }

        public Argument(string name)
        {
            Value = name ?? "";
        }

        /* Conversion operators. */
        public static implicit operator Argument(string value)
        {
            return new(value);
        }

        public static implicit operator string(Argument argument)
        {
            return argument.Value;
        }

        /* Public methods. */
        public override string Generate()
        {
            return Value;
        }
    }
}