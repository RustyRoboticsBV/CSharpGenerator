namespace CSharpGenerator
{
    /// <summary>
    /// A class modifier generator.
    /// </summary>
    public sealed class StructModifier : GeneratorChoice<StructModifierKeywordID>
    {
        /* Casting operators. */
        public static implicit operator StructModifier(StructModifierKeywordID keywordID)
        {
            return new()
            {
                ID = keywordID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(StructModifierKeywordID keywordID)
        {
            switch (keywordID)
            {
                case StructModifierKeywordID.Static:
                    return "static";
                case StructModifierKeywordID.Readonly:
                    return "readonly";
                default:
                    return "";
            }
        }
    }
}