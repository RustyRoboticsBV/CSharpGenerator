namespace CSharpGenerator
{
    /// <summary>
    /// A method implementation generator.
    /// </summary>
    public class MethodImplementation : GeneratorList<Code>
    {
        /* Protected properties. */
        protected override string Separator => "\n";

        /* Constructors. */
        public MethodImplementation() : base() { }

        public MethodImplementation(Code code) : base(code) { }

        public MethodImplementation(Code[] code) : base(code) { }

        public MethodImplementation(string code) : base((Code)code) { }

        public MethodImplementation(string[] code) : base()
        {
            for (int i = 0; i < code.Length; i++)
            {
                Elements.Add((Code)code[i]);
            }
        }

        /* Casting operators. */
        public static implicit operator MethodImplementation(string code)
        {
            return new(code);
        }

        public static implicit operator MethodImplementation(string[] code)
        {
            return new(code);
        }

        public static implicit operator MethodImplementation(Code code)
        {
            return new(code);
        }

        public static implicit operator MethodImplementation(Code[] code)
        {
            return new(code);
        }

        /* Public methods. */
        public override string Generate()
        {
            string code = base.Generate().Trim();
            if (code == "")
                return "";
            else if (code.StartsWith("=>"))
                return code;
            else
            {
                Block block = code;
                return block.Generate();
            }
        }
    }
}