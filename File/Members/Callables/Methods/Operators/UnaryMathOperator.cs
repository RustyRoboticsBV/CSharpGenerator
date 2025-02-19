namespace CSharpGenerator
{
    /// <summary>
    /// A unary math operator generator.
    /// </summary>
    public class UnaryMathOperator : Operator
    {
        /* Public properties. */
        public string ReturnType { get; set; } = "int";
        public UnaryMathOperatorSymbol Operator { get; set; } = UnaryMathOperatorID.Negative;
        public Parameter Operand { get; set; } = new();

        /* Constructors. */
        public UnaryMathOperator() { }

        public UnaryMathOperator(UnaryMathOperator other) : base(other)
        {
            ReturnType = other.ReturnType;
            Operator = new(other.Operator);
            Operand = new(other.Operand);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new UnaryMathOperator(this);
        }

        public override string Generate()
        {
            return $"{Summary.Generate("\n")}public static {ReturnType} operator {Operator.Generate()}({Operand.Generate()})"
                + $"\n{Implementation.Generate()}";
        }
    }
}