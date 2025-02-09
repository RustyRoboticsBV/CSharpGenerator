namespace CSharpGenerator
{
    /// <summary>
    /// A constructor declaration generator.
    /// </summary>
    public abstract class Constructor : Identifier
    {
        /* Public properties. */
        public AccessModifier Access { get; private set; }
        public ParameterList Parameters { get; private set; }
        public Block Implementation { get; private set; }

        /* Constructors. */
        public Constructor(Summary summary, AttributeList attributes, AccessModifier access, string name,
            ParameterList parameters, Block implementation) : base(summary, attributes, name)
        {
            if (access == null)
                Access = new();
            if (parameters == null)
                Parameters = new();
            if (implementation == null)
                implementation = new();

            Access = access;
            Parameters = parameters;
            Implementation = implementation;
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Name}({Parameters})\n{Implementation}";
        }
    }
}
