namespace CSharpGenerator
{
    /// <summary>
    /// A file member list generator.
    /// </summary>
    public class FileMemberList : MemberList<IFileMember>
    {
        /* Casting operators. */
        public static implicit operator FileMemberList(IFileMember[] members)
        {
            return new FileMemberList()
            {
                Elements = members
            };
        }
    }
}