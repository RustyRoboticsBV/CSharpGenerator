namespace CSharpGenerator
{
    /// <summary>
    /// A struct member section generator.
    /// </summary>
    public class StructSection : Generator, IStructMember
    {
        /* Public properties. */
        public DelimitedComment Title { get; set; } = new();
        public StructMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            if (Title.Text != "")
                return $"{Title.Generate("\n")}{Members.Generate()}";
            else
                return $"{Members.Generate()}";
        }
    }
}