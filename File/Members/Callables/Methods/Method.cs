namespace Rusty.CSharpGenerator
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
        public GenericConstraintList GenericConstraints { get; set; } = new();
        public MethodImplementation Implementation { get; set; } = "";

        /* Constructors. */
        public Method() { }

        public Method(Method other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Modifiers = new(other.Modifiers);
            ReturnType = other.ReturnType;
            Name = other.Name;
            GenericParameters = new(other.GenericParameters);
            Parameters = new(other.Parameters);
            GenericConstraints = new(other.GenericConstraints);
            Implementation = new(other.Implementation);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Method(this);
        }

        public override string Generate()
        {
            string implementation = Implementation.Generate();
            if (implementation == "")
                implementation = ";";
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifiers.Generate(" ")}"
                + $"{ReturnType} {Name}{GenericParameters.Generate("")}({Parameters.Generate()}){GenericConstraints.Generate()}"
                + $"\n{implementation}";
        }
    }
}