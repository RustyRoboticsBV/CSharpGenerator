namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A struct member section generator.
    /// </summary>
    public class StructSection : Generator, IStructMember
    {
        /* Public properties. */
        public DelimitedComment Title { get; set; } = new();
        public StructMemberList Members { get; set; } = new();

        /* Constructors. */
        public StructSection() { }

        public StructSection(StructSection other)
        {
            Title = new(other.Title);
            Members = new(other.Members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new StructSection(this);
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