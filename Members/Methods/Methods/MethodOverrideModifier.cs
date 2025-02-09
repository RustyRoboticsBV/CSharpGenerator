namespace CSharpGenerator
{
    /// <summary>
    /// A method override modifier generator.
    /// </summary>
    public sealed class MethodOverrideModifier : GeneratorChoice<OverrideKeywordID>
    {
        /* Constructors. */
        public MethodOverrideModifier() : this(OverrideKeywordID.None) { }

        public MethodOverrideModifier(OverrideKeywordID value) : base(value) { }

        /* Casting operators. */
        public static implicit operator MethodOverrideModifier(OverrideKeywordID keywordID)
        {
            return new(keywordID);
        }

        public static implicit operator OverrideKeywordID(MethodOverrideModifier modifier)
        {
            return modifier.ID;
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(OverrideKeywordID keywordID)
        {
            switch (keywordID)
            {
                case OverrideKeywordID.Virtual:
                    return "virtual";
                case OverrideKeywordID.Override:
                    return "override";
                case OverrideKeywordID.Sealed:
                    return "override sealed";
                case OverrideKeywordID.New:
                    return "new";
                default:
                    return "";
            }
        }
    }
}