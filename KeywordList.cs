namespace CSharpGenerator
{
    /// <summary>
    /// A keyword list generator.
    /// </summary>
    public sealed class KeywordList : GeneratorList<Keyword>
    {
        /* Protected properties. */
        protected override string Separator => ", ";

        /* Constructors. */
        public KeywordList() : this(null) { }

        public KeywordList(Keyword[] keywords) : base(keywords) { }

        /* Casting operators. */
        public static implicit operator KeywordList(Keyword[] keywords)
        {
            return new(keywords);
        }

        public static implicit operator KeywordList(Keyword keyword)
        {
            return new(new Keyword[1] { keyword });
        }
    }
}