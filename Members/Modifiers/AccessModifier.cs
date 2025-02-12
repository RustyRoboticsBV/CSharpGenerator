namespace CSharpGenerator
{
    /// <summary>
    /// An access modifier generator.
    /// </summary>
    public sealed class AccessModifier : GeneratorChoice<AccessKeywordID>
    {
        /* Casting operators. */
        public static implicit operator AccessModifier(AccessKeywordID keywordID)
        {
            return new()
            {
                ID = keywordID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(AccessKeywordID keywordID)
        {
            switch (keywordID)
            {
                case AccessKeywordID.Public:
                    return "public";
                case AccessKeywordID.Internal:
                    return "internal";
                case AccessKeywordID.Protected:
                    return "protected";
                case AccessKeywordID.Private:
                    return "private";
                case AccessKeywordID.ProtectedInternal:
                    return "protected internal";
                case AccessKeywordID.PrivateProtected:
                    return "private protected";
                case AccessKeywordID.File:
                    return "file";
                default:
                    return "";
            }
        }
    }
}