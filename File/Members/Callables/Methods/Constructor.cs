namespace CSharpGenerator
{
    /// <summary>
    /// A constructor generator.
    /// </summary>
    public class Constructor : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string TypeName { get; set; } = "Name";
        public ParameterList Parameters { get; set; } = new();

        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Access.Generate(" ")}{TypeName}({Parameters.Generate()})"
                + $"\n{Implementation.Generate()}";
        }
    }
}