namespace CSharpGenerator
{
    /// <summary>
    /// An argument generator.
    /// </summary>
    public class Argument : Generator
    {
        /* Public properties. */
        public string Value { get; set; } = "";

        /* Constructors. */
        public Argument() { }

        public Argument(Argument other)
        {
            Value = other.Value;
        }

        public Argument(string value)
        {
            Value = value;
        }

        /* Casting operators. */
        public static implicit operator Argument(string value)
        {
            return new(value);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Argument(this);
        }

        public override string Generate()
        {
            return Value;
        }
    }
}