namespace CSharpGenerator
{
    /// <summary>
    /// A set of type members, which starts with a delimited comment.
    /// </summary>
    public sealed class Section : Member
    {
        /* Public properties. */
        /// <summary>
        /// The header comment of the section.
        /// </summary>
        public DelimitedComment Comment { get; set; }
        /// <summary>
        /// The members in the section.
        /// </summary>
        public Member[] Members { get; set; }

        /* Constructors. */
        public Section() : this(null, null) { }

        public Section(DelimitedComment comment, Member[] members) : base(null, null, null, null)
        {
            Comment = comment ?? new();
            Members = members ?? new Member[0];
        }

        /* Public methods. */
        public override string Generate()
        {
            string code = "";
            for (int i = 0; i < Members.Length; i++)
            {
                if (code != "")
                    code += "\n\n";
                code += Members[i].Generate();
            }

            return $"{Comment.Generate("\n")}{code}";
        }
    }
}