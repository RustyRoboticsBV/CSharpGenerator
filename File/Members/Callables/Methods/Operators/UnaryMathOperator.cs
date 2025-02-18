using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A unary math operator generator.
    /// </summary>
    public class UnaryMathOperator : Operator
    {
        /* Public properties. */
        public string ReturnType { get; set; } = "int";
        public UnaryMathOperatorID Operator { get; set; } = UnaryMathOperatorID.Negative;
        public Parameter Operand { get; set; } = new();

        /* Constructors. */
        public UnaryMathOperator() { }

        public UnaryMathOperator(UnaryMathOperator other) : base(other)
        {
            Operator = other.Operator;
            Operand = new(other.Operand);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new UnaryMathOperator(this);
        }

        public override string Generate()
        {
            return $"{Summary.Generate("\n")}public static {ReturnType} operator {GetName(Operator)}({Operand.Generate()})"
                + $"\n{Implementation.Generate()}";
        }

        /* Private methods. */
        private static string GetName(UnaryMathOperatorID id)
        {
            switch (id)
            {
                case UnaryMathOperatorID.Negative:
                    return "-";
                case UnaryMathOperatorID.Increment:
                    return "++";
                case UnaryMathOperatorID.Decrement:
                    return "--";
                default:
                    throw new ArgumentException(id.ToString());
            }
        }
    }
}