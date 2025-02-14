namespace CSharpGenerator
{
    /// <summary>
    /// A field generator.
    /// </summary>
    public class Field : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Private;
        public string Type { get; set; } = "int";
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";

        /* Public methods. */
        public override string Generate()
        {
            if (Value == "")
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{Type} {Name};";
            else
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{Type} {Name} = {Value};";
        }
    }
}