namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A unary math operator symbol generator.
    /// </summary>
    public class UnaryMathOperatorSymbol : GeneratorChoice<UnaryMathOperatorID>
    {
        /* Constructors. */
        public UnaryMathOperatorSymbol() : base() { }

        public UnaryMathOperatorSymbol(UnaryMathOperatorSymbol other) : base(other) { }

        public UnaryMathOperatorSymbol(UnaryMathOperatorID id) : base(id) { }

        public UnaryMathOperatorSymbol(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator UnaryMathOperatorSymbol(UnaryMathOperatorID id)
        {
            return new(id);
        }

        /* Public propertys. */
        public override Generator Copy()
        {
            return new UnaryMathOperatorSymbol(this);
        }

        /* Protected propertys. */
        protected override Keyword GetKeyword(UnaryMathOperatorID id)
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
                    return "";
            }
        }
    }
}