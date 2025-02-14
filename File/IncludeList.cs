namespace CSharpGenerator
{
    /// <summary>
    /// An include member list generator.
    /// </summary>
    public class IncludeList : GeneratorList<Include>
    {
        /* Protected properties. */
        protected override string Separator => "\n";

        /* Casting operators. */
        public static implicit operator IncludeList(Include[] members)
        {
            return new IncludeList()
            {
                Elements = members
            };
        }

        public static implicit operator IncludeList(Include member)
        {
            return new Include[] { member };
        }
    }
}