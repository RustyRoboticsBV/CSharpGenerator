namespace CSharpGenerator
{
    /// <summary>
    /// A class generator.
    /// </summary>
    public class Class : Generator, IClassMember, IStructMember, INamespaceMember, IFileMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public ClassModifier Modifier { get; set; } = ClassModifierID.None;
        public string Name { get; set; } = "";
        public GenericParameterList GenericParameters { get; set; } = new();
        public ClassInheritance Inheritance { get; set; } = new();
        public ClassMemberList Members { get; set; } = new();
        public GenericConstraintList GenericConstraints { get; set; } = new();

        public string BaseClass
        {
            get => Inheritance.BaseClass;
            set => Inheritance.BaseClass = value;
        }
        public ArgumentList Interfaces
        {
            get => Inheritance.Interfaces;
            set => Inheritance.Interfaces = value;
        }

        /* Constructors. */
        public Class() { }

        public Class(Class other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Modifier = new(other.Modifier);
            Name = other.Name;
            GenericParameters = new(other.GenericParameters);
            Inheritance = new(other.Inheritance);
            Members = new(other.Members);
            GenericConstraints = new(other.GenericConstraints);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Class(this);
        }

        public override string Generate()
        {
            Block contents = new Block(Members);
            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Access.Generate(" ")}{Modifier.Generate(" ")}"
                + $"class {Name}{GenericParameters.Generate()}{Inheritance.Generate()}{GenericConstraints.Generate()}"
                + $"\n{contents.Generate()}";
        }
    }
}
