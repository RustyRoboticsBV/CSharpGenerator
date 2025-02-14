namespace CSharpGenerator
{
    /// <summary>
    /// A class modifier generator.
    /// </summary>
    public sealed class ClassModifier : GeneratorChoice<ClassModifierKeywordID>
    {
        /* Casting operators. */
        public static implicit operator ClassModifier(ClassModifierKeywordID keywordID)
        {
            return new()
            {
                ID = keywordID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(ClassModifierKeywordID keywordID)
        {
            switch (keywordID)
            {
                case ClassModifierKeywordID.Static:
                    return "static";
                case ClassModifierKeywordID.Abstract:
                    return "abstract";
                default:
                    return "";
            }
        }
    }
}