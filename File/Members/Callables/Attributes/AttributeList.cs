namespace CSharpGenerator
{
    /// <summary>
    /// A generator for attribute lists.
    /// </summary>
    public sealed class AttributeList : GeneratorList<Attribute>
    {
        /* Protected properties. */
        protected override string Separator => ", ";

        /* Conversion operators. */
        public static implicit operator AttributeList(Attribute attribute)
        {
            return new()
            {
                Elements = new Attribute[] { attribute }
            };
        }
        
        public static implicit operator AttributeList(Attribute[] attributes)
        {
            return new()
            {
                Elements = attributes
            };
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
            if (Elements.Length == 0)
                return "";
            else
                return $"[{base.Generate().Replace("[", "").Replace("]", "")}]";
        }
    }
}