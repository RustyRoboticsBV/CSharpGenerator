namespace CSharpGenerator
{
    /// <summary>
    /// A generator for adding an attribute to an object.
    /// </summary>
    public sealed class Attribute : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The name of the attribute.
        /// </summary>
        public Name Name { get; private set; }
        /// <summary>
        /// The arguments of the attribute.
        /// </summary>
        public ArgumentList Arguments { get; private set; }

        /* Constructors. */
        public Attribute() : this(null, null) { }

        public Attribute(Name name) : this(name, null) { }

        public Attribute(Name name, ArgumentList arguments)
        {
            Name = name ?? new();
            Arguments = arguments ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Arguments.Length == 0)
                return $"[{Name.Generate()}]";
            else
                return $"[{Name.Generate()}({Arguments.Generate()})]";
        }
    }
}