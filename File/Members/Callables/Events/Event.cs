namespace CSharpGenerator
{
    /// <summary>
    /// An event generator.
    /// </summary>
    public class Event : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string Delegate { get; set; } = "Action";
        public string Name { get; set; } = "Name";

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}event {Delegate} {Name};";
        }
    }
}