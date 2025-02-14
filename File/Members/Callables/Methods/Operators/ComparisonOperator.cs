using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A comparison operator generator.
    /// </summary>
    public class ComparisonOperator : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public string ReturnType { get; set; } = "bool";
        public ComparisonOperatorID Operator { get; set; } = ComparisonOperatorID.Equal;
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
        private static string GetName(ComparisonOperatorID id)
        {
            switch (id)
            {
                case ComparisonOperatorID.Equal:
                    return "==";
                case ComparisonOperatorID.NotEqual:
                    return "!=";
                case ComparisonOperatorID.Greater:
                    return ">";
                case ComparisonOperatorID.Less:
                    return "<";
                case ComparisonOperatorID.GreaterOrEqual:
                    return ">=";
                case ComparisonOperatorID.LessOrEqual:
                    return "<=";
                default:
                    throw new ArgumentException(id.ToString());
            }
        }
    }
}