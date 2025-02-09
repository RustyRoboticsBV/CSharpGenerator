namespace CSharpGenerator
{
    /// <summary>
    /// A generator list generator.
    /// </summary>
    public abstract class GeneratorList<T> : Generator where T : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The element generators.
        /// </summary>
        public T[] Elements { get; private set; }
        /// <summary>
        /// The number of elements.
        /// </summary>
        public int Length => Elements.Length;

        /* Protected properties. */
        /// <summary>
        /// The separator string that gets inserted between elements.
        /// </summary>
        protected abstract string Separator { get; }

        /* Constructors. */
        public GeneratorList() : this(new T[0]) { }

        public GeneratorList(T[] elements)
        {
            Elements = elements ?? new T[0];
        }

        /* Casting operators. */
        public static implicit operator T[](GeneratorList<T> list)
        {
            return list.Elements;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Elements.Length == 0)
                return "";
            else
            {
                string code = Elements[0].Generate();
                for (int i = 1; i < Length; i++)
                {
                    code += $"{Separator}{Elements[i].Generate()}";
                }
                return code;
            }
        }
    }
}