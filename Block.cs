namespace CSharpGenerator
{
    /// <summary>
    /// A code block generator.
    /// </summary>
    public sealed class Block : Generator
    {
        /* Public properties. */
        public string Contents { get; private set; }
        public string Indentation { get; private set; }

        /* Constructors. */
        public Block() : this("") { }

        public Block(string contents, int indentation = 4)
        {
            if (contents == null)
                contents = "";

            Contents = contents;
            Indentation = new string(' ', indentation);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Contents == "")
                return "{ }";
            else
                return $"{'{'}{Indentation}{Contents.Replace("\n", $"\n{Indentation}")}{'}'}";
        }
    }
}
