namespace CSharpGenerator
{
    /// <summary>
    /// A generator list generator.
    /// </summary>
    public abstract class MemberList<T> : Generator where T : IMember
    {
        /* Public properties. */
        /// <summary>
        /// The element generators.
        /// </summary>
        public T[] Elements { get; set; }
        /// <summary>
        /// The number of elements.
        /// </summary>
        public int Length => Elements.Length;

        /* Indexers. */
        public T this[int index]
        {
            get => Elements[index];
            set => Elements[index] = value;
        }

        /* Protected properties. */
        /// <summary>
        /// The separator string that gets inserted between elements.
        /// </summary>
        protected virtual string Separator => "\n";

        /* Constructors. */
        public MemberList() : this(new T[0]) { }

        public MemberList(T[] elements)
        {
            Elements = elements ?? new T[0];
        }

        /* Casting operators. */
        public static implicit operator T[](MemberList<T> list)
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