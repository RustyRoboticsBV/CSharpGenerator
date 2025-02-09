namespace CSharpGenerator
{
    /// <summary>
    /// An keyword generator.
    /// </summary>
    public sealed class Keyword : Generator
    {
        /* Public properties. */
        public string Name { get; private set; }

        /* Constructors. */
        public Keyword() : this("") { }

        public Keyword(string name)
        {
            Name = name;
        }

        /* Casting operators. */
        public static implicit operator Keyword(string name)
        {
            return new(name);
        }

        /* Public methods. */
        public override string Generate()
        {
            return Name;
        }
    }
}