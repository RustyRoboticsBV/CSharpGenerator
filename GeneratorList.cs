using System.Collections.Generic;

namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A generator list.
    /// </summary>
    public abstract class GeneratorList<T> : Generator where T : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The element generators.
        /// </summary>
        public List<T> Elements { get; set; } = new();
        /// <summary>
        /// The number of elements.
        /// </summary>
        public int Length => Elements.Count;

        /* Protected properties. */
        /// <summary>
        /// The separator string that gets inserted between elements.
        /// </summary>
        protected virtual string Separator => ", ";

        /* Indexers. */
        public T this[int index]
        {
            get => Elements[index];
            set => Elements[index] = value;
        }

        /* Constructors. */
        public GeneratorList() : this(new T[0]) { }

        public GeneratorList(GeneratorList<T> other) : this()
        {
            for (int i = 0; i < other.Elements.Count; i++)
            {
                Elements.Add(other.Elements[i].Copy() as T);
            }
        }

        public GeneratorList(T element) : this(new T[1] { element }) { }

        public GeneratorList(T[] elements)
        {
            Elements = new(elements);
        }

        public GeneratorList(List<T> elements)
        {
            Elements = elements;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Length == 0)
                return "";
            else
            {
                string code = Elements[0]?.Generate();
                for (int i = 1; i < Length; i++)
                {
                    code += $"{Separator}{Elements[i]?.Generate()}";
                }
                return code;
            }
        }
    }
}