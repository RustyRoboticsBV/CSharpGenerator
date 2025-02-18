namespace CSharpGenerator
{
    /// <summary>
    /// A keyword generator.
    /// </summary>
    public class Keyword : Generator
    {
        /* Public properties. */
        public string Name { get; set; }

        /* Constructors. */
        public Keyword() { }

        public Keyword(Keyword other)
        {
            Name = other.Name;
        }

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
        public override Generator Copy()
        {
            return new Keyword(this);
        }

        public override string Generate()
        {
            return Name;
        }
    }
}