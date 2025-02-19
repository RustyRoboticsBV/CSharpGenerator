namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A binary math operator symbol generator.
    /// </summary>
    public class BinaryMathOperatorSymbol : GeneratorChoice<BinaryMathOperatorID>
    {
        /* Constructors. */
        public BinaryMathOperatorSymbol() : base() { }

        public BinaryMathOperatorSymbol(BinaryMathOperatorSymbol other) : base(other) { }

        public BinaryMathOperatorSymbol(BinaryMathOperatorID id) : base(id) { }

        public BinaryMathOperatorSymbol(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator BinaryMathOperatorSymbol(BinaryMathOperatorID id)
        {
            return new(id);
        }

        /* Public propertys. */
        public override Generator Copy()
        {
            return new BinaryMathOperatorSymbol(this);
        }

        /* Protected propertys. */
        protected override Keyword GetKeyword(BinaryMathOperatorID id)
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
                    return "";
            }
        }
    }
}