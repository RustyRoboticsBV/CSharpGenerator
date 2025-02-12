namespace CSharpGenerator
{
    /// <summary>
    /// A class member list generator.
    /// </summary>
    public class ClassMemberList : MemberList<IClassMember>
    {
        /* Casting operators. */
        public static implicit operator ClassMemberList(IClassMember[] members)
        {
            return new ClassMemberList()
            {
                Elements = members
            };
        }
    }
}