namespace CSharpGenerator
{
    /// <summary>
    /// A parameter generator, meant for method declaration.
    /// </summary>
    public class Parameter : Generator
    {
        /* Public properties. */
        public ParameterModifier Modifier { get; set; } = ParameterModifierID.None;
        public string Type { get; set; } = "void";
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