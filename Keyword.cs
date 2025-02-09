namespace CSharpGenerator
{
    /// <summary>
    /// An keyword generator.
    /// </summary>
    public sealed class Keyword : Generator
    {
        /* Public properties. */
        public Name Name { get; private set; }

        /* Constructors. */
        public Keyword() : this(null) { }

        public Keyword(string name)
        {
            Name = name ?? "";
        }

        /* Casting operators. */
        public static implicit operator Keyword(string name)
        {
            return new(name);
        }

        public static implicit operator string(Keyword keyword)
        {
            return keyword.Name;
        }

        /* Public methods. */
        public override string Generate()
        {
            return Name.Generate();
        }
    }
}