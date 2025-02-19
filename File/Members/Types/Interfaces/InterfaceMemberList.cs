namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A interface member list generator.
    /// </summary>
    public class InterfaceMemberList : MemberList<Generator, IInterfaceMember>
    {
        /* Constructors. */
        public InterfaceMemberList() : base() { }

        public InterfaceMemberList(InterfaceMemberList other) : base(other) { }

        public InterfaceMemberList(IInterfaceMember member) : base(member) { }

        public InterfaceMemberList(IInterfaceMember[] members) : base(members) { }

        /* Casting operators. */
        public static implicit operator InterfaceMemberList(IInterfaceMember[] members)
        {
            return new(members);
        }

        public static implicit operator InterfaceMemberList(Interface[] members)
        {
            return new(members);
        }

        public static implicit operator InterfaceMemberList(Property[] members)
        {
            return new(members);
        }

        public static implicit operator InterfaceMemberList(Method[] members)
        {
            return new(members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new InterfaceMemberList(this);
        }
    }
}