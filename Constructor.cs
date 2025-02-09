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
            Access = access ?? new();
            Parameters = parameters ?? new();
            Implementation = implementation ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Name.Generate()}({Parameters.Generate()})\n{Implementation.Generate()}";
        }
    }
}