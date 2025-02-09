namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all method declaration generators.
    /// </summary>
    public abstract class BaseMethod<T> : Member<T> where T : ModifierList, new()
    {
        /* Public properties. */
        public Type ReturnType { get; private set; }
        public ParameterList Parameters { get; private set; }
        public Block Implementation { get; private set; }

        /* Constructors. */
        public BaseMethod(Summary summary, AttributeList attributes, T modifiers, Type returnType,
            Name name, ParameterList parameters, Block implementation) : base(summary, attributes, modifiers, name)
        {
            ReturnType = returnType ?? new();
            Parameters = parameters ?? new();
            Implementation = implementation ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Implementation != "")
                return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Modifiers.Generate(" ")}{ReturnType.Generate(" ")}{Name.Generate()}({Parameters.Generate()})\n{Implementation.Generate()}";
            else
                return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Modifiers.Generate(" ")}{ReturnType.Generate(" ")}{Name.Generate()}({Parameters.Generate()})";
        }
    }
}