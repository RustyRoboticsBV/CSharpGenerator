namespace CSharpGenerator
{
    /// <summary>
    /// A class member list generator.
    /// </summary>
    public class ClassMemberList : MemberList<Generator, IClassMember>
    {
        /* Constructors. */
        public ClassMemberList() : base() { }

        public ClassMemberList(ClassMemberList other) : base(other) { }

        public ClassMemberList(IClassMember member) : this(new IClassMember[1] { member }) { }

        public ClassMemberList(IClassMember[] members) : base(members) { }

        /* Casting operators. */
        public static implicit operator ClassMemberList(IClassMember[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Class member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Class[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Struct member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Struct[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Interface member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Interface[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Enum member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Enum[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Field member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Field[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Delegate member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Delegate[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Event member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Event[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Property member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Property[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Constructor member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Constructor[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Finalizer member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Finalizer[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Operator member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Operator[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Indexer member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Indexer[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(Method member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(Method[] members)
        {
            return new(members);
        }

        public static implicit operator ClassMemberList(ClassSection member)
        {
            return new IClassMember[1] { member };
        }

        public static implicit operator ClassMemberList(ClassSection[] members)
        {
            return new(members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ClassMemberList(this);
        }
    }
}