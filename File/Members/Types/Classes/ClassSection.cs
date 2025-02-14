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