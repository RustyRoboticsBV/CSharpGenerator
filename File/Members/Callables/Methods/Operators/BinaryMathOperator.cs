using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A binary math operator generator.
    /// </summary>
    public class BinaryMathOperator : Operator
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public string ReturnType { get; set; } = "int";
        public BinaryMathOperatorID Operator { get; set; } = BinaryMathOperatorID.Add;
        public Parameter Operand1 { get; set; } = new();
        public Parameter Operand2 { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
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