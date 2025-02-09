namespace CSharpGenerator
{
    /// <summary>
    /// A field generator.
    /// </summary>
    public sealed class Field : Member<FieldModifiers>
    {
        /* Public properties. */
        public Type Type { get; private set; }

        /* Constructors. */
        public Field(Summary summary, AttributeList attributes, FieldModifiers modifiers, Type type, Name name)
            : base(summary, attributes, modifiers, name)
        {
            Type = type ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Modifiers.Generate(" ")}{Type.Generate(" ")}{Name.Generate()};";
        }
    }
}