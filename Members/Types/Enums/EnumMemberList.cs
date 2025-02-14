namespace CSharpGenerator
{
    /// <summary>
    /// An enum member list generator.
    /// </summary>
    public class EnumMemberList : MemberList<IEnumMember>
    {
        /* Protected properties. */
        protected override string Separator => ",\n";

        /* Casting operators. */
        public static implicit operator EnumMemberList(IEnumMember[] members)
        {
            return new EnumMemberList()
            {
                Elements = members
            };
        }

        public static implicit operator EnumMemberList(string[] members)
        {
            IEnumMember[] results = new IEnumMember[members.Length];
            for (int i = 0; i < members.Length; i++)
            {
                results[i] = new EnumMember() { Name = members[i] };
            }
            return results;
        }
    }
}