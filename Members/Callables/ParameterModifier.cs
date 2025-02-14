namespace CSharpGenerator
{
    /// <summary>
    /// A parameter/argument pass keyword generator.
    /// </summary>
    public sealed class PassKeyword : GeneratorChoice<PassKeywordID>
    {
        /* Casting operators. */
        public static implicit operator PassKeyword(PassKeywordID keywordID)
        {
            return new()
            {
                ID = keywordID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(PassKeywordID keywordID)
        {
            switch (keywordID)
            {
                case PassKeywordID.In:
                    return "in";
                case PassKeywordID.Out:
                    return "out";
                case PassKeywordID.Ref:
                    return "ref";
                default:
                    return "";
            }
        }
    }
}