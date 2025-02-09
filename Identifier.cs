namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all identifier generator.
    /// </summary>
    public abstract class Identifier : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The XML documentation of the identifier.
        /// </summary>
        public Summary Summary { get; private set; }
        /// <summary>
        /// The attributes of this identifier.
        /// </summary>
        public AttributeList Attributes { get; private set; }
        /// <summary>
        /// The name of the identifier.
        /// </summary>
        public Name Name { get; private set; }

        /* Constructors. */
        public Identifier() : this(null, null, null) { }

        public Identifier(Name name) : this(null, null, name) { }

        public Identifier(Summary summary, AttributeList attributes, Name name)
        {
            Summary = summary ?? new();
            Attributes = attributes ?? new();
            Name = name ?? new();
        }
    }
}
