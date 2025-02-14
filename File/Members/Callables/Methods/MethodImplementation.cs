namespace CSharpGenerator
{
    /// <summary>
    /// A method implementation generator.
    /// </summary>
    public class MethodImplementation : GeneratorList<Code>
    {
        /* Protected properties. */
        protected override string Separator => "\n";

        /* Casting operators. */
        public static implicit operator MethodImplementation(string code)
        {
            return (Code)code;
        }

        public static implicit operator MethodImplementation(string[] code)
        {
            Code[] result = new Code[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                result[i] = code[i];
            }
            return result;
        }

        public static implicit operator MethodImplementation(Code code)
        {
            return new Code[] { code };
        }

        public static implicit operator MethodImplementation(Code[] code)
        {
            return new()
            {
                Elements = code
            };
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