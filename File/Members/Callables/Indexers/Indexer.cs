namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// An indexer generator.
    /// </summary>
    public class Indexer : Generator, IClassMember, IStructMember, IInterfaceMember 
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string ReturnType { get; set; } = "int";
        public ParameterList Parameters { get; set; } = new();
        public Getter Getter { get; set; } = new();
        public Setter Setter { get; set; } = new();

        /* Constructors. */
        public Indexer() { }

        public Indexer(Indexer other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            ReturnType = other.ReturnType;
            Parameters = new(other.Parameters);
            Getter = new(other.Getter);
            Setter = new(other.Setter);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Indexer(this);
        }

        public override string Generate()
        {
            // Generate implementation.
            string getter = Getter != null ? Getter.Generate("") : "";
            string setter = Setter != null ? Setter.Generate("") : "";

            // Default implementation.
            Block block = $"{(Getter != null ? Getter.Generate("\n") : "")}{(Setter != null ? Setter.Generate() : "")}";
            string implementation = $"\n{block.Generate()}";

            // Special case: default implementation.
            if (getter == "get;")
            {
                if (setter == "set;")
                    implementation = "{ get; set; }";
                else if (setter == "")
                    implementation = "{ get; }";
            }

            // Special case: lamdba getter.
            if (Setter == null && getter.StartsWith("get =>"))
                implementation = getter.Substring(4);

            // Special case: lamdba setter.
            if (Getter == null && setter.StartsWith("set =>"))
                implementation = setter.Substring(4);

            // Generate code.
            string code = $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}{ReturnType} this"
                + $"[{Parameters.Generate()}] {implementation}";

            return code;
        }
    }
}