namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A property generator.
    /// </summary>
    public class Property : Generator, IClassMember, IStructMember, IInterfaceMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public PropertyModifier Modifier { get; set; } = PropertyModifierID.None;
        public string Type { get; set; } = "int";
        public string Name { get; set; } = "";
        public Getter Getter { get; set; } = new();
        public Setter Setter { get; set; } = new();
        public string Default { get; set; } = "";

        /* Constructors. */
        public Property() { }

        public Property(Property other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Modifier = new(other.Modifier);
            Type = other.Type;
            Name = other.Name;
            Getter = new(other.Getter);
            Setter = new(other.Setter);
            Default = other.Default;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Property(this);
        }

        public override string Generate()
        {
            // Generate implementation.
            string getter = Getter != null ? Getter.Generate("") : "";
            string setter = Setter != null ? Setter.Generate("") : "";

            // Default implementation.
            Block block = $"{(Getter != null ? Getter.Generate("\n") : "")}{(Setter != null ? Setter.Generate() : "")}";
            string implementation = $"\n{block.Generate()}";

            // Special case: default implementation.
            if (getter == "get;")
            {
                if (setter == "set;")
                    implementation = "{ get; set; }";
                else if (setter == "")
                    implementation = "{ get; }";
            }

            // Special case: lamdba getter.
            if (Setter == null && getter.StartsWith("get =>"))
                implementation = getter.Substring(4);

            // Special case: lamdba setter.
            if (Getter == null && setter.StartsWith("set =>"))
                implementation = setter.Substring(4);

            // Generate code.
            string code = $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{Modifier.Generate(" ")}" +
                $"{Type} {Name} {implementation}";

            // Add default value.
            if (Default != "")
                return code + $" = {Default}";
            else
                return code;
        }
    }
}