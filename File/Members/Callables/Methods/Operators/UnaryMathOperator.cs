using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A unary math operator generator.
    /// </summary>
    public class UnaryMathOperator : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public string ReturnType { get; set; } = "int";
        public UnaryMathOperatorID Operator { get; set; } = UnaryMathOperatorID.Negative;
        public Parameter Operand { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
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