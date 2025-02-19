namespace CSharpGenerator
{
    /// <summary>
    /// A parameter generator, meant for method declaration.
    /// </summary>
    public class Parameter : Generator
    {
        /* Public properties. */
        public ParameterModifier Modifier { get; set; } = ParameterModifierID.None;
        public string Type { get; set; } = "int";
        public string Name { get; set; } = "";
        public Argument Default { get; set; } = new();

        /* Constructors. */
        public Parameter() { }

        public Parameter(Parameter other)
        {
            Modifier = new(other.Modifier);
            Type = other.Type;
            Name = other.Name;
            Default = new(other.Default);
        }

        public Parameter(ParameterModifier modifier, string type, string name, string @default = "")
        {
            Modifier = modifier;
            Type = type;
            Name = name;
            Default = @default;
        }

        public Parameter(string type, string name, string @default = "")
        {
            Type = type;
            Name = name;
            Default = @default;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Parameter(this);
        }

        public override string Generate()
        {
            if (Type != "" && Name != "")
            {
                if (Default.Value != "" && Modifier.ID != ParameterModifierID.Out && Modifier.ID != ParameterModifierID.Ref)
                    return $"{Modifier.Generate(" ")}{Type} {Name} = {Default.Generate()}";
                else
                    return $"{Modifier.Generate(" ")}{Type} {Name}";
            }
            else
                return "";
        }
    }
}