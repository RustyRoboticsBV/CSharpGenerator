namespace CSharpGenerator
{
    /// <summary>
    /// A code block generator.
    /// </summary>
    public class Block : Generator
    {
        /* Public properties. */
        public Generator Contents { get; set; }
        public static int Indentation { get; set; } = 4;

        /* Constructors. */
        public Block() { }

        public Block(string code)
        {
            Contents = (Code)code;
        }

        public Block(Generator generator)
        {
            Contents = generator;
        }

        /* Casting operators. */
        public static implicit operator Block(string contents)
        {
            return new(contents);
        }

        public static implicit operator Block(Code contents)
        {
            return new(contents);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Contents == null)
                return "{ }";
            else
            {
                string indentation = new string(' ', Indentation);
                return $"{"{\n"}{indentation}{Contents.Generate().Replace("\n", $"\n{indentation}")}{"\n}"}";
            }
        }
    }
}
