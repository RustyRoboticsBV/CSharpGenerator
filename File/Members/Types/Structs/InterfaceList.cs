namespace CSharpGenerator
{
    /// <summary>
    /// A struct interface implementation list generator.
    /// </summary>
    public class InterfaceList : Generator
    {
        /* Public properties. */
        public ArgumentList Interfaces { get; set; } = new();

        /* Constructors. */
        public InterfaceList() { }

        public InterfaceList(InterfaceList other)
        {
            Interfaces = new(other.Interfaces);
        }

        /* Casting operators. */
        public static implicit operator InterfaceList(ArgumentList interfaces)
        {
            return new() { Interfaces = interfaces };
        }

        public static implicit operator InterfaceList(string[] interfaces)
        {
            return (ArgumentList)interfaces;
        }

        public static implicit operator InterfaceList(string @interface)
        {
            return (ArgumentList)@interface;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new InterfaceList(this);
        }

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