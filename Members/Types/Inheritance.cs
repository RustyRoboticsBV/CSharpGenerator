namespace CSharpGenerator
{
    /// <summary>
    /// A type inheritance generator.
    /// </summary>
    public sealed class Inheritance : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The name of the parent type.
        /// </summary>
        public Name Name { get; private set; }

        /* Constructors. */
        public Inheritance() : this(null) { }

        public Inheritance(Name name)
        {
            Name = name ?? "";
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Name.Text == "")
                return "";
            else
                return $" : {Name.Generate()}";
        }
    }
}