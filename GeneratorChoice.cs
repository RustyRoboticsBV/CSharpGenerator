using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A generator choice.
    /// </summary>
    public abstract class GeneratorChoice<T> : Generator where T : Enum
    {
        /* Public properties. */
        /// <summary>
        /// The generator id.
        /// </summary>
        public T ID { get; private set; }

        /* Constructors. */
        public GeneratorChoice(T id)
        {
            ID = id;
        }

        /* Public methods. */
        public override sealed string Generate()
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