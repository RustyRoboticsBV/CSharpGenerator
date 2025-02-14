namespace CSharpGenerator
{
    /// <summary>
    /// A property getter generator.
    /// </summary>
    public class Getter : Generator
    {
        /* Public properties. */
        public AccessModifier Access { get; set; } = AccessID.None;
        public MethodImplementation Implementation { get; set; } = "";

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