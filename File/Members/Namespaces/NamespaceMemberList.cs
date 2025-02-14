namespace CSharpGenerator
{
    /// <summary>
    /// A namespace member list generator.
    /// </summary>
    public class NamespaceMemberList : MemberList<INamespaceMember>
    {
        /* Casting operators. */
        public static implicit operator NamespaceMemberList(INamespaceMember[] members)
        {
            return new NamespaceMemberList()
            {
                Elements = members
            };
        }
    }
}