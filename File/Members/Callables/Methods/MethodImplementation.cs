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
            return new Code() { Text = code };
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
            string code = base.Generate();
            Block block = new()
            {
                Contents = new Code() { Text = code }
            };
            return block.Generate();
        }
    }
}
