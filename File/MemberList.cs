namespace CSharpGenerator
{
    /// <summary>
    /// A member list generator.
    /// </summary>
    public abstract class MemberList<T, InterfaceT> : GeneratorList<T>
        where T : Generator
        where InterfaceT : IMember
    {
        /* Protected properties */
        protected override string Separator => "\n";

        /* Constructors. */
        public MemberList() : base() { }

        public MemberList(MemberList<T, InterfaceT> other) : base(other) { }

        public MemberList(T member) : base(member) { }

        public MemberList(T[] members) : base(members) { }

        public MemberList(InterfaceT member) : this(new InterfaceT[1] { member }) { }

        public MemberList(InterfaceT[] members)
        {
            for (int i = 0; i < members.Length; i++)
            {
                if (members[i] is T generator)
                    Elements.Add(generator);
            }
        }

        /* Protected methods. */
        protected void Populate<U>(U[] members) where U : T
        {
            foreach (U member in members)
            {
                Elements.Add(member);
            }
        }
    }
}