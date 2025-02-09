namespace CSharpGenerator
{
    /// <summary>
    /// A code block generator.
    /// </summary>
    public sealed class Block : Generator
    {
        /* Public properties. */
        public string Contents { get; private set; }
        public static int Indentation { get; set; } = 4;

        /* Constructors. */
        public Block() : this("") { }

        public Block(string contents)
        {
            Contents = contents ?? "";
        }

        /* Conversion operators. */
        public static implicit operator Block(string contents)
        {
            return new Block(contents);
        }

        public static implicit operator string(Block block)
        {
            return block.Contents;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Contents == "")
                return "{ }";
            else
            {
                string indentation = new string(' ', Indentation);
                return $"{"{\n"}{indentation}{Contents.Replace("\n", $"\n{indentation}")}{"\n}"}";
            }
        }
    }
}
