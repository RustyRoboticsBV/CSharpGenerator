namespace CSharpGenerator
{
    /// <summary>
    /// A code block generator.
    /// </summary>
    public sealed class Block : Generator
    {
        /* Public properties. */
        public Generator Contents { get; set; }
        public static int Indentation { get; set; } = 4;
        
        /* Casting operators. */
        public static implicit operator Block(string contents)
        {
            return new() { Contents = new Code() { Text = contents } };
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
