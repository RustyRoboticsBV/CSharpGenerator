namespace CSharpGenerator
{
    /// <summary>
    /// A name generator.
    /// </summary>
    public sealed class Name : Generator
    {
        /* Public properties. */
        public string Text { get; private set; }

        /* Constructors. */
        public Name() : this(null) { }

        public Name(string name)
        {
            Text = name ?? "";
        }

        /* Casting operators. */
        public static implicit operator Name(string text)
        {
            return new(text);
        }

        public static implicit operator string(Name name)
        {
            return name.Text;
        }

        /* Public methods. */
        public override string Generate()
        {
            return Text;
        }
    }
}