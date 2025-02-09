namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all method declaration generators.
    /// </summary>
    public sealed class MethodDeclaration : Identifier
    {
        /* Public properties. */
        public MethodModifiers Modifiers { get; private set; }
        public Type ReturnType { get; private set; }
        public ParameterList Parameters { get; private set; }
        public Block Implementation { get; private set; }

        /* Constructors. */
        public MethodDeclaration(Summary summary, AttributeList attributes, MethodModifiers modifiers, Type returnType,
            string name, ParameterList parameters, Block implementation) : base(summary, attributes, name)
        {
            Modifiers = modifiers ?? new();
            ReturnType = returnType ?? new();
            Parameters = parameters ?? new();
            Implementation = implementation ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Modifiers.Generate(" ")}{ReturnType.Generate(" ")}{Name}({Parameters})\n{Implementation}";
        }
    }
}