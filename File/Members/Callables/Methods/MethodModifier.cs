namespace CSharpGenerator
{
    /// <summary>
    /// A method modifier generator.
    /// </summary>
    public sealed class MethodModifier : GeneratorChoice<MethodModifierKeywordID>
    {
        /* Casting operators. */
        public static implicit operator MethodModifier(MethodModifierKeywordID keywordID)
        {
            return new()
            {
                ID = keywordID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(MethodModifierKeywordID keywordID)
        {
            switch (keywordID)
            {
                case MethodModifierKeywordID.Static:
                    return "static";
                case MethodModifierKeywordID.StaticNew:
                    return "static new";
                case MethodModifierKeywordID.Abstract:
                    return "abstract";
                case MethodModifierKeywordID.Virtual:
                    return "virtual";
                case MethodModifierKeywordID.Override:
                    return "override";
                case MethodModifierKeywordID.OverrideSealed:
                    return "override sealed";
                case MethodModifierKeywordID.New:
                    return "new";
                case MethodModifierKeywordID.NewVirtual:
                    return "new virtual";
                case MethodModifierKeywordID.Readonly:
                    return "readonly";
                default:
                    return "";
            }
        }
    }
}