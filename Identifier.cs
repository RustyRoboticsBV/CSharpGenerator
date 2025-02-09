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
        public string Name { get; private set; }

        /* Constructors. */
        public Identifier(string name) : this(null, null, name) { }

        public Identifier(Summary summary, AttributeList attributes, string name)
        {
            if (attributes == null)
                attributes = new();
            if (summary == null)
                summary = new();
            if (name == null)
                name = "";

            Summary = summary;
            Attributes = attributes;
            Name = name;
        }
    }
}
