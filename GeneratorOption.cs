namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A generator optional.
    /// </summary>
    public abstract class GeneratorOption<T> : Generator where T : Generator
    {
        /* Public properties. */
        /// <summary>
        /// Whether or not this generator should generate code.
        /// </summary>
        public bool Enabled { get; private set; }
        /// <summary>
        /// The actual generator.
        /// </summary>
        public abstract Generator Generator { get; }

        /* Constructors. */
        public GeneratorOption(bool enabled)
        {
            Enabled = enabled;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Enabled)
                return Generator.Generate();
            else
                return "";
        }
    }
}