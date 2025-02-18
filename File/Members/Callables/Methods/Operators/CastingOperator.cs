namespace CSharpGenerator
{
    /// <summary>
    /// A casting operator generator.
    /// </summary>
    public class CastingOperator : Operator
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public CastingModifier Modifier { get; set; } = CastingModifierID.Implicit;
        public string ReturnType { get; set; } = "int";
        public Parameter Operand { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}public static {Modifier.Generate(" ")}operator {ReturnType}({Operand.Generate()})"
                + $"\n{Implementation.Generate()}";
        }
    }
}