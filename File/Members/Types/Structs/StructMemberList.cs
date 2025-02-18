namespace CSharpGenerator
{
    /// <summary>
    /// A struct member list generator.
    /// </summary>
    public class StructMemberList : MemberList<Generator, IStructMember>
    {
        /* Constructors. */
        public StructMemberList() : base() { }

        public StructMemberList(IStructMember member) : this(new IStructMember[1] { member }) { }

        public StructMemberList(IStructMember[] members) : base(members) { }

        /* Casting operators. */
        public static implicit operator StructMemberList(IStructMember[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Class member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Class[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Struct member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Struct[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Interface member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Interface[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Enum member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Enum[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Field member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Field[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Delegate member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Delegate[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Event member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Event[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Property member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Property[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Constructor member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Constructor[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Destructor member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Destructor[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Operator member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Operator[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Indexer member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Indexer[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(Method member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(Method[] members)
        {
            return new(members);
        }

        public static implicit operator StructMemberList(StructSection member)
        {
            return new IStructMember[1] { member };
        }

        public static implicit operator StructMemberList(StructSection[] members)
        {
            return new(members);
        }
    }
}