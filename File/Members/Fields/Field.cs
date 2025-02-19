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
        public bool Readonly { get; set; }
        public string Type { get; set; } = "int";
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";

        /* Constructors. */
        public Field() { }

        public Field(Field field)
        {
            Summary = new(field.Summary);
            Attributes = new(field.Attributes);
            Access = field.Access.ID;
            Type = field.Type;
            Name = field.Name;
            Value = field.Value;
        }

        public Field(Summary summary, AttributeList attributes, AccessID access, string type, string name, string value = "")
        {
            Summary = summary;
            Attributes = attributes;
            Access = access;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(Summary summary, AttributeList attributes, string type, string name, string value = "")
        {
            Summary = summary;
            Attributes = attributes;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(Summary summary, AccessID access, string type, string name, string value = "")
        {
            Summary = summary;
            Access = access;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(Summary summary, string type, string name, string value = "")
        {
            Summary = summary;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(AttributeList attributes, AccessID access, string type, string name, string value = "")
        {
            Attributes = attributes;
            Access = access;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(AttributeList attributes, string type, string name, string value = "")
        {
            Attributes = attributes;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(AccessID access, string type, string name, string value = "")
        {
            Access = access;
            Type = type;
            Name = name;
            Value = value;
        }

        public Field(string type, string name, string value = "")
        {
            Type = type;
            Name = name;
            Value = value;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Field(this);
        }

        public override string Generate()
        {
            string @readonly = Readonly ? "readonly " : "";
            if (Value == "")
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{@readonly}{Type} {Name};";
            else
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{@readonly}{Type} {Name} = {Value};";
        }
    }
}