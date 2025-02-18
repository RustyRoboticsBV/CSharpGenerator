namespace CSharpGenerator
{
    /// <summary>
    /// A generator for attribute lists.
    /// </summary>
    public class AttributeList : GeneratorList<Attribute>
    {
        /* Constructors. */
        public AttributeList() : base() { }

        public AttributeList(Attribute attribute) : base(attribute) { }

        public AttributeList(Attribute[] attributes) : base(attributes) { }

        /* Conversion operators. */
        public static implicit operator AttributeList(Attribute attribute)
        {
            return new(attribute);
        }
        
        public static implicit operator AttributeList(Attribute[] attributes)
        {
            return new(attributes);
        }

        public static implicit operator AttributeList(string attribute)
        {
            return (Attribute)attribute;
        }

        public static implicit operator AttributeList(string[] attributes)
        {
            Attribute[] result = new Attribute[attributes.Length];
            for (int i = 0; i < attributes.Length; i++)
            {
                result[i] = attributes[i];
            }
            return result;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Length == 0)
                return "";
            else
                return $"[{base.Generate().Replace("[", "").Replace("]", "")}]";
        }
    }
}