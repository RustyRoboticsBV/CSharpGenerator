namespace CSharpGenerator
{
    /// <summary>
    /// A class member section generator.
    /// </summary>
    public class ClassSection : Generator, IClassMember
    {
        /* Public properties. */
        public DelimitedComment Title { get; set; } = new();
        public ClassMemberList Members { get; set; } = new();

        /* Constructors. */
        public ClassSection() { }

        public ClassSection(ClassSection other)
        {
            Title = new(other.Title);
            Members = new(other.Members);
        }

        public ClassSection(string title, params IClassMember[] member)
        {
            Title = title;
            Members = new(member);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ClassSection(this);
        }

        public override string Generate()
        {
            if (Title.Text != "")
                return $"{Title.Generate("\n")}{Members.Generate()}";
            else
                return $"{Members.Generate()}";
        }
    }
}