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
        public FieldModifier Modifier { get; set; } = FieldModifierID.None;
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
            Modifier = field.Modifier;
            Type = field.Type;
            Name = field.Name;
            Value = field.Value;
        }

        public Field(Summary summary, AttributeList attributes, AccessID access, FieldModifierID modifier, string type, string name, string value = "")
        {
            Summary = summary;
            Attributes = attributes;
            Access = access;
            Modifier = modifier;
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
            if (Value == "")
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{Modifier.Generate(" ")}{Type} {Name};";
            else
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{Modifier.Generate(" ")}{Type} {Name} = {Value};";
        }
    }
}