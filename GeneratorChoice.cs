namespace CSharpGenerator
{
    /// <summary>
    /// A generator choice.
    /// </summary>
    public abstract class GeneratorChoice<T> : Generator where T : System.Enum
    {
        /* Public properties. */
        /// <summary>
        /// The generator id.
        /// </summary>
        public T ID { get; set; } = default;

        /* Public methods. */
        public override string Generate()
        {
            return GetKeyword(ID).Generate();
        }

        /* Protected methods. */
        /// <summary>
        /// Return a generator that corresponds to a generator ID.
        /// </summary>
        protected abstract Generator GetKeyword(T id);
    }
}