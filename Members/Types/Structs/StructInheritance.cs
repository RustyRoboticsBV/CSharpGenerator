namespace CSharpGenerator
{
    /// <summary>
    /// A struct interface implementation list generator.
    /// </summary>
    public class StructInheritance : Generator
    {
        /* Public properties. */
        public ArgumentList Interfaces { get; set; } = new();

        /* Casting operators. */
        public static implicit operator StructInheritance(ArgumentList interfaces)
        {
            return new() { Interfaces = interfaces };
        }

        public static implicit operator StructInheritance(string[] interfaces)
        {
            return (ArgumentList)interfaces;
        }

        public static implicit operator StructInheritance(string @interface)
        {
            return (ArgumentList)@interface;
        }

        /* Public methods. */
        public override string Generate()
        {
            string list = Interfaces.Generate();
            if (list != "")
                return $" : {list}";
            else
                return "";
        }
    }
}