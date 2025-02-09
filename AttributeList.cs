namespace CSharpGenerator
{
    /// <summary>
    /// A generator for attribute lists.
    /// </summary>
    public sealed class AttributeList : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The attributes in the list.
        /// </summary>
        public Attribute[] Attributes { get; private set; }
        /// <summary>
        /// The number of attributes in the list.
        /// </summary>
        public int Length => Attributes.Length;

        /* Constructors. */
        public AttributeList() : this(null) { }

        public AttributeList(Attribute[] attributes)
        {
            if (attributes == null)
                attributes = new Attribute[0];

            Attributes = attributes;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Length == 0)
                return "";
            else
            {
                string code = Attributes[0].Generate();
                for (int i = 1; i < Length; i++)
                {
                    code += $", {Attributes[i].Generate()}";
                }
                return $"[{code.Replace("[", "").Replace("]", "")}]";
            }
        }
    }
}
