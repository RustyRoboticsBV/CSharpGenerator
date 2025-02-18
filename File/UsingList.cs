namespace CSharpGenerator
{
    /// <summary>
    /// An include member list generator.
    /// </summary>
    public class UsingList : GeneratorList<Using>
    {
        /* Protected properties. */
        protected override string Separator => "\n";

        /* Constructors. */
        public UsingList() : base() { }

        public UsingList(Using member) : base(member) { }

        public UsingList(Using[] members) : base(members) { }

        public UsingList(string member) : base(member) { }

        public UsingList(string[] members) : base()
        {
            foreach (string member in members)
            {
                Elements.Add((Using)member);
            }
        }

        /* Casting operators. */
        public static implicit operator UsingList(Using member)
        {
            return new(member);
        }

        public static implicit operator UsingList(Using[] members)
        {
            return new(members);
        }

        public static implicit operator UsingList(string member)
        {
            return new(member);
        }

        public static implicit operator UsingList(string[] members)
        {
            return new(members);
        }
    }
}