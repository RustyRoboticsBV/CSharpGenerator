namespace CSharpGenerator
{
    public class Method : Generator, IClassMember, IStructMember, IInterfaceMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public MethodModifier Modifiers { get; set; } = MethodModifierID.None;
        public string ReturnType { get; set; } = "void";
        public string Name { get; set; } = "Name";
        public ArgumentList GenericParameters { get; set; } = new();
        public ParameterList Parameters { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
        public override string Generate()
        {
            string implementation = Implementation.Generate();
            if (implementation == "")
                implementation = ";";
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifiers.Generate(" ")}"
                + $"{ReturnType} {Name}{GenericParameters.Generate("")}({Parameters.Generate()})\n{implementation}";
        }
    }
}