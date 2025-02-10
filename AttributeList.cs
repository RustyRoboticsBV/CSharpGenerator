namespace CSharpGenerator
{
    /// <summary>
    /// A generator for attribute lists.
    /// </summary>
    public sealed class AttributeList : GeneratorList<Attribute>
    {
        /* Protected properties. */
        protected override string Separator => ", ";

        /* Constructors. */
        public AttributeList() : this(null) { }

        public AttributeList(Attribute[] attributes) : base(attributes) { }

        /* Conversion operators. */
        public static implicit operator AttributeList(Attribute[] attributes)
        {
            return new(attributes);
        }

        public static implicit operator AttributeList(Attribute attribute)
        {
            return new(new Attribute[1] { attribute });
        }

        public static implicit operator AttributeList(string attribute)
        {
            return new(new Attribute[1] { new Attribute(attribute) });
        }

        public static implicit operator AttributeList((Name, ArgumentList) attribute)
        {
            return new(new Attribute[1] { new(attribute.Item1, attribute.Item2) });
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Elements.Length == 0)
                return "";
            else
                return $"[{base.Generate().Replace("[", "").Replace("]", "")}]";
        }
    }
}