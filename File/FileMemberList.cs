namespace CSharpGenerator
{
    /// <summary>
    /// A file member list generator.
    /// </summary>
    public class FileMemberList : MemberList<Generator, IFileMember>
    {
        /* Operators. */
        public FileMemberList() : base() { }

        public FileMemberList(IFileMember member) : base(member) { }

        public FileMemberList(IFileMember[] members) : base(members) { }

        /* Casting operators. */
        public static implicit operator FileMemberList(IFileMember[] members)
        {
            return new(members);
        }

        public static implicit operator FileMemberList(Namespace member)
        {
            return new(member);
        }

        public static implicit operator FileMemberList(Namespace[] members)
        {
            return new(members);
        }

        public static implicit operator FileMemberList(Class member)
        {
            return new(member);
        }

        public static implicit operator FileMemberList(Class[] members)
        {
            return new(members);
        }

        public static implicit operator FileMemberList(Struct member)
        {
            return new(member);
        }

        public static implicit operator FileMemberList(Struct[] members)
        {
            return new(members);
        }

        public static implicit operator FileMemberList(Interface member)
        {
            return new(member);
        }

        public static implicit operator FileMemberList(Interface[] members)
        {
            return new(members);
        }

        public static implicit operator FileMemberList(Enum member)
        {
            return new(member);
        }

        public static implicit operator FileMemberList(Enum[] members)
        {
            return new(members);
        }

        public static implicit operator FileMemberList(Delegate member)
        {
            return new(member);
        }

        public static implicit operator FileMemberList(Delegate[] members)
        {
            return new(members);
        }
    }
}