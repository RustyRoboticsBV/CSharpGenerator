namespace CSharpGenerator
{
    /// <summary>
    /// A class inheritance generator.
    /// </summary>
    public class ClassInheritance : Generator
    {
        /* Public properties. */
        public string BaseClass { get; set; } = "";
        public ArgumentList Interfaces { get; set; } = new();

        /* Constructors. */
        public ClassInheritance() { }

        public ClassInheritance(ClassInheritance other)
        {
            BaseClass = other.BaseClass;
            Interfaces = new(other.Interfaces);
        }

        public ClassInheritance(string baseClass)
        {
            BaseClass = baseClass;
        }

        public ClassInheritance(string baseClass, Argument @interface)
        {
            BaseClass = baseClass;
            Interfaces = new();
        }

        public ClassInheritance(string baseClass, ArgumentList interfaces)
        {
            BaseClass = baseClass;
            Interfaces = interfaces;
        }

        public ClassInheritance(string baseClass, string @interface)
        {
            BaseClass = baseClass;
            Interfaces = @interface;
        }

        public ClassInheritance(string baseClass, params string[] interfaces)
        {
            BaseClass = baseClass;
            Interfaces = interfaces;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ClassInheritance(this);
        }

        public override string Generate()
        {
            string list = BaseClass;
            if (Interfaces.Length > 0)
            {
                if (list != "")
                    list += ", ";
                list += Interfaces.Generate();
            }
            if (list != "")
                return $" : {list}";
            else
                return "";
        }
    }
}