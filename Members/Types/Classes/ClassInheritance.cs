namespace CSharpGenerator
{
    public class ClassInheritance : Generator
    {
        /* Public properties. */
        public string ParentClass { get; set; } = "";
        public ArgumentList Interfaces { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            string list = ParentClass;
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