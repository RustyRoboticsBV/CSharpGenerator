namespace CSharpGenerator
{
    public class Method : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessKeywordID.Public;
        public MethodModifier Modifiers { get; set; } = MethodModifierKeywordID.None;
        public string ReturnType { get; set; } = "void";
        public string Name { get; set; } = "Name";
        public ParameterList Parameters { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
        public override sealed string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifiers.Generate(" ")}"
                + $"{ReturnType} {Name}({Parameters.Generate()})\n{Implementation.Generate()}";
        }

        public string GenerateBody()
        {
            return Implementation.Generate();
        }
    }
}