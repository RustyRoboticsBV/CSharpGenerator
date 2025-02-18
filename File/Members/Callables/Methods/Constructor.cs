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
        public bool IsStatic { get; set; }
        public string TypeName { get; set; } = "Name";
        public ParameterList Parameters { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
        public override string Generate()
        {
            if (IsStatic)
            {
                return $"{Summary.Generate("\n")}{TypeName}({Parameters.Generate()})"
                    + $"\n{Implementation.Generate()}";
            }

            return $"{Summary.Generate("\n")}{Access.Generate(" ")}{TypeName}({Parameters.Generate()})"
                + $"\n{Implementation.Generate()}";
        }
    }
}