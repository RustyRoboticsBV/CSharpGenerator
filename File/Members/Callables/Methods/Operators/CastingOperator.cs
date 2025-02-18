namespace CSharpGenerator
{
    /// <summary>
    /// A casting operator generator.
    /// </summary>
    public class CastingOperator : Operator
    {
        /* Public properties. */
        public CastingModifier Modifier { get; set; } = CastingModifierID.Implicit;
        public string ReturnType { get; set; } = "int";
        public Parameter Operand { get; set; } = new();

        /* Constructors. */
        public CastingOperator() : base() { }

        public CastingOperator(CastingOperator other) : base(other)
        {
            Modifier = new(other.Modifier);
            ReturnType = other.ReturnType;
            Operand = new(other.Operand);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new CastingOperator(this);
        }

        public override string Generate()
        {
            return $"{Summary.Generate("\n")}public static {Modifier.Generate(" ")}operator {ReturnType}({Operand.Generate()})"
                + $"\n{Implementation.Generate()}";
        }
    }
}