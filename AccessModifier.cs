namespace CSharpGenerator
{
    /// <summary>
    /// An access modifier generator.
    /// </summary>
    public sealed class AccessModifier : GeneratorChoice<AccessKeywordID>
    {
        /* Constructors. */
        public AccessModifier() : this(AccessKeywordID.None) { }

        public AccessModifier(AccessKeywordID value) : base(value) { }

        /* Casting operators. */
        public static implicit operator AccessModifier(AccessKeywordID keywordID)
        {
            return new(keywordID);
        }

        public static implicit operator AccessKeywordID(AccessModifier modifier)
        {
            return modifier.ID;
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(AccessKeywordID keywordID)
        {
            switch (keywordID)
            {
                case AccessKeywordID.Public:
                    return "public";
                case AccessKeywordID.Internal:
                    return"internal";
                case AccessKeywordID.Protected:
                    return"protected";
                case AccessKeywordID.Private:
                    return"private";
                case AccessKeywordID.ProtectedInternal:
                    return"protected internal";
                case AccessKeywordID.PrivateProtected:
                    return"private protected";
                case AccessKeywordID.File:
                    return"file";
                default:
                    return "";
            }
        }
    }
}