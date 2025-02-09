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
        public string Name { get; private set; }
        /// <summary>
        /// The arguments of the attribute.
        /// </summary>
        public ArgumentList Arguments { get; private set; }

        /* Constructors. */
        public Attribute(string name) : this(name, new()) { }

        public Attribute(string name, ArgumentList arguments)
        {
            Name = name ?? "";
            Arguments = arguments ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Arguments.Length == 0)
                return $"[{Name}]";
            else
                return $"[{Name}({Arguments})]";
        }
    }
}