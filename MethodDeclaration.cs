namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all method declaration generators.
    /// </summary>
    public sealed class MethodDeclaration : Identifier
    {
        /* Public properties. */
        public MethodModifiers Modifiers { get; private set; }
        public ParameterList Parameters { get; private set; }
        public Block Implementation { get; private set; }

        /* Constructors. */
        public MethodDeclaration(Summary summary, AttributeList attributes, MethodModifiers modifiers, string name,
            ParameterList parameters, Block implementation) : base(summary, attributes, name)
        {
            if (modifiers == null)
                modifiers = new();
            if (parameters == null)
                parameters = new();
            if (implementation == null)
                implementation = new();

            Modifiers = modifiers;
            Parameters = parameters;
            Implementation = implementation;
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Modifiers.Generate(" ")}{Name}({Parameters})\n{Implementation}";
        }
    }
}