namespace CSharpGenerator
{
    /// <summary>
    /// A namespace member list generator.
    /// </summary>
    public class NamespaceMemberList : MemberList<Generator, INamespaceMember>
    {
        /* Constructors. */
        public NamespaceMemberList() : base() { }

        public NamespaceMemberList(NamespaceMemberList other) : base(other) { }

        public NamespaceMemberList(INamespaceMember member) : base(member) { }

        public NamespaceMemberList(INamespaceMember[] members) : base(members) { }

        /* Casting operators. */
        public static implicit operator NamespaceMemberList(INamespaceMember[] members)
        {
            return new(members);
        }

        public static implicit operator NamespaceMemberList(Namespace member)
        {
            return new((INamespaceMember)member);
        }

        public static implicit operator NamespaceMemberList(Namespace[] members)
        {
            return new(members);
        }

        public static implicit operator NamespaceMemberList(Class member)
        {
            return new((INamespaceMember)member);
        }

        public static implicit operator NamespaceMemberList(Class[] members)
        {
            return new(members);
        }

        public static implicit operator NamespaceMemberList(Struct member)
        {
            return new((INamespaceMember)member);
        }

        public static implicit operator NamespaceMemberList(Struct[] members)
        {
            return new(members);
        }

        public static implicit operator NamespaceMemberList(Interface member)
        {
            return new((INamespaceMember)member);
        }

        public static implicit operator NamespaceMemberList(Interface[] members)
        {
            return new(members);
        }

        public static implicit operator NamespaceMemberList(Enum member)
        {
            return new((INamespaceMember)member);
        }

        public static implicit operator NamespaceMemberList(Enum[] members)
        {
            return new(members);
        }

        public static implicit operator NamespaceMemberList(Delegate member)
        {
            return new((INamespaceMember)member);
        }

        public static implicit operator NamespaceMemberList(Delegate[] members)
        {
            return new(members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new NamespaceMemberList(this);
        }
    }
}