namespace CSharpGenerator
{
    /// <summary>
    /// An enum member list generator.
    /// </summary>
    public class EnumMemberList : MemberList<Generator, IEnumMember>
    {
        /* Protected properties. */
        protected override string Separator => ",\n";

        /* Constructors. */
        public EnumMemberList() : base() { }

        public EnumMemberList(EnumMemberList other) : base(other) { }

        public EnumMemberList(EnumMember member) : this(new EnumMember[1] { member }) { }

        public EnumMemberList(EnumMember[] members) : base()
        {
            Populate(members);
        }

        public EnumMemberList(IEnumMember member) : base(new IEnumMember[1] { member }) { }

        public EnumMemberList(IEnumMember[] members) : base(members) { }

        public EnumMemberList(string member) : this(new string[1] {member}) { }

        public EnumMemberList(string[] members)
        {
            foreach (string member in members)
            {
                Elements.Add((EnumMember)member);
            }
        }

        /* Casting operators. */
        public static implicit operator EnumMemberList(IEnumMember[] members)
        {
            return new(members);
        }

        public static implicit operator EnumMemberList(string[] members)
        {
            return new(members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new EnumMemberList(this);
        }
    }
}