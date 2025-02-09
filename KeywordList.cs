namespace CSharpGenerator
{
    /// <summary>
    /// A keyword list generator.
    /// </summary>
    public sealed class KeywordList : GeneratorList<Keyword>
    {
        /* Public properties. */
        public override string Separator => ", ";

        /* Constructors. */
        public KeywordList() : this(null) { }

        public KeywordList(Keyword[] keywords) : base(keywords) { }

        /* Casting operators. */
        public static implicit operator KeywordList(Keyword[] keywords)
        {
            return new(keywords);
        }

        public static implicit operator Keyword[](KeywordList keywordList)
        {
            return keywordList.Elements;
        }
    }
}