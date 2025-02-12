namespace CSharpGenerator
{
    /// <summary>
    /// A parameter generator, meant for method declaration.
    /// </summary>
    public sealed class Parameter : Generator
    {
        /* Public properties. */
        public PassKeyword Pass { get; set; } = PassKeywordID.None;
        public string Type { get; set; } = "void";
        public string Name { get; set; } = "";
        public Argument Default { get; set; }

        /* Public methods. */
        public override string Generate()
        {
            if (Type != "" && Name != "")
            {
                if (Default.Value != "")
                    return $"{Pass.Generate(" ")}{Type} {Name} = {Default.Generate()}";
                else
                    return $"{Pass.Generate(" ")}{Type} {Name}";
            }
            else
                return "";
        }
    }
}