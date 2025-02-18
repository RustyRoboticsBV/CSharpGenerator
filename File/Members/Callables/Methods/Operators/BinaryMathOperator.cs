using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A binary math operator generator.
    /// </summary>
    public class BinaryMathOperator : Operator
    {
        /* Public properties. */
        public string ReturnType { get; set; } = "int";
        public BinaryMathOperatorID Operator { get; set; } = BinaryMathOperatorID.Add;
        public Parameter Operand1 { get; set; } = new();
        public Parameter Operand2 { get; set; } = new();

        /* Constructors. */
        public BinaryMathOperator() : base() { }

        public BinaryMathOperator(BinaryMathOperator other) : base()
        {
            ReturnType = other.ReturnType;
            Operator = other.Operator;
            Operand1 = new(other.Operand1);
            Operand2 = new(other.Operand2);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new BinaryMathOperator(this);
        }

        public override string Generate()
        {
            ParameterList parameters = new Parameter[] { Operand1, Operand2 };
            return $"{Summary.Generate("\n")}public static {ReturnType} operator {GetName(Operator)}({parameters.Generate()})"
                + $"\n{Implementation.Generate()}";
        }

        /* Private methods. */
        private static string GetName(BinaryMathOperatorID id)
        {
            switch (id)
            {
                case BinaryMathOperatorID.Add:
                    return "+";
                case BinaryMathOperatorID.Subtract:
                    return "-";
                case BinaryMathOperatorID.Multiply:
                    return "*";
                case BinaryMathOperatorID.Divide:
                    return "/";
                case BinaryMathOperatorID.Modulo:
                    return "%";
                default:
                    throw new ArgumentException(id.ToString());
            }
        }
    }
}