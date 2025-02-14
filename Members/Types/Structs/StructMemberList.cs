namespace CSharpGenerator
{
    /// <summary>
    /// A struct member list generator.
    /// </summary>
    public class StructMemberList : MemberList<IStructMember>
    {
        /* Casting operators. */
        public static implicit operator StructMemberList(IStructMember[] members)
        {
            return new StructMemberList()
            {
                Elements = members
            };
        }
    }
}