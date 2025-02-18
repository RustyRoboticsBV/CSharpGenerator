namespace CSharpGenerator
{
    /// <summary>
    /// A property setter generator.
    /// </summary>
    public class Setter : Generator
    {
        /* Public properties. */
        public static Setter None => null;

        public AccessModifier Access { get; set; } = AccessID.None;
        public MethodImplementation Implementation { get; set; } = "";

        /* Constructors. */
        public Setter() { }

        public Setter(Setter other)
        {
            Access = new(other.Access);
            Implementation = new(other.Implementation);
        }

        /* Casting operators. */
        public static implicit operator Setter(string fieldName)
        {
            if (fieldName == "")
                return new();

            return new()
            {
                Implementation = $"=> {fieldName} = value;"
            };
        }

        public static implicit operator Setter(Code code)
        {
            return new()
            {
                Implementation = code
            };
        }

        public static implicit operator Setter(Block block)
        {
            return new()
            {
                Implementation = block.Generate()
            };
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Setter(this);
        }

        public override string Generate()
        {
            if (Implementation == null)
                return "";

            string code = Implementation.Generate().Trim();
            if (code == "")
                return "set;";
            if (code.StartsWith("=>"))
                return $"{Access.Generate(" ")}set {code}";
            else
                return $"{Access.Generate(" ")}set\n{code}";
        }
    }
}