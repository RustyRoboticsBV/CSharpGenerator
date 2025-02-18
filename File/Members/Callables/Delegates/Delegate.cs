namespace CSharpGenerator
{
    /// <summary>
    /// A delegate generator.
    /// </summary>
    public class Delegate : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string ReturnType { get; set; } = "void";
        public string Name { get; set; } = "Name";
        public GenericParameterList GenericParameters { get; set; } = new();
        public ParameterList Parameters { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}delegate {ReturnType} {Name}"
                + $"{GenericParameters.Generate()}({Parameters.Generate()});";
        }
    }
}