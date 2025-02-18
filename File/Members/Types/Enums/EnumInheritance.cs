namespace CSharpGenerator
{
    public class EnumInheritance : Generator
    {
        /* Public properties. */
        public string ParentType { get; set; } = "";

        /* Constructors. */
        public EnumInheritance() { }

        public EnumInheritance(EnumInheritance other)
        {
            ParentType = other.ParentType;
        }

        /* Casting operators. */
        public static implicit operator EnumInheritance(string parentType)
        {
            return new() { ParentType = parentType };
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new EnumInheritance(this);
        }

        public override string Generate()
        {
            if (ParentType != "")
                return $" : {ParentType}";
            else
                return "";
        }
    }
}