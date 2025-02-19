namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A comparison operator symbol generator.
    /// </summary>
    public class ComparisonOperatorSymbol : GeneratorChoice<ComparisonOperatorID>
    {
        /* Constructors. */
        public ComparisonOperatorSymbol() : base() { }

        public ComparisonOperatorSymbol(ComparisonOperatorSymbol other) : base(other) { }

        public ComparisonOperatorSymbol(ComparisonOperatorID id) : base(id) { }

        public ComparisonOperatorSymbol(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator ComparisonOperatorSymbol(ComparisonOperatorID id)
        {
            return new(id);
        }

        /* Public propertys. */
        public override Generator Copy()
        {
            return new ComparisonOperatorSymbol(this);
        }

        /* Protected propertys. */
        protected override Keyword GetKeyword(ComparisonOperatorID id)
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
                    return "";
            }
        }
    }
}