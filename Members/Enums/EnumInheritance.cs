namespace CSharpGenerator
{
    public class EnumInheritance : Generator
    {
        /* Public properties. */
        public string ParentType { get; set; } = "";

        /* Casting operators. */
        public static implicit operator EnumInheritance(string parentType)
        {
            return new() { ParentType = parentType };
        }

        /* Public methods. */
        public override string Generate()
        {
            if (ParentType != "")
                return $" : {ParentType}";
            else
                return "";
        }
    }
}