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

        /// <summary>
        /// The separator string that gets inserted between elements.
        /// </summary>
        public abstract string Separator { get; }

        /* Constructors. */
        public GeneratorList() : this(null) { }

        public GeneratorList(T[] elements)
        {
            if (elements == null)
                elements = new T[0];

            Elements = elements;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Elements.Length == 0)
                return "";
            else
            {
                string code = Elements[0].Generate();
                for (int i = 1; i < code.Length; i++)
                {
                    code += $"{Separator}{Elements[i].Generate()}";
                }
                return code;
            }
        }
    }
}