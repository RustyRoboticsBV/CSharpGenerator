namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A property getter generator.
    /// </summary>
    public class Getter : Generator
    {
        /* Public properties. */
        public static Getter None => null;

        public AccessModifier Access { get; set; } = AccessID.None;
        public MethodImplementation Implementation { get; set; } = "";

        /* Constructors. */
        public Getter() { }

        public Getter(Getter other)
        {
            Access = new(other.Access);
            Implementation = new(other.Implementation);
        }

        /* Casting operators. */
        public static implicit operator Getter(string fieldName)
        {
            if (fieldName == "")
                return new();

            return new()
            {
                Implementation = $"=> {fieldName};"
            };
        }

        public static implicit operator Getter(Code code)
        {
            return new()
            {
                Implementation = code
            };
        }

        public static implicit operator Getter(Block block)
        {
            return new()
            {
                Implementation = block.Generate()
            };
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Getter(this);
        }

        public override string Generate()
        {
            if (Implementation == null)
                return "";

            string code = Implementation.Generate().Trim();
            if (code == "")
                return "get;";
            if (code.StartsWith("=>"))
                return $"{Access.Generate(" ")}get {code}";
            else
                return $"{Access.Generate(" ")}get\n{code}";
        }
    }
}