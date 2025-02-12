namespace CSharpGenerator
{
    /// <summary>
    /// A code string generator.
    /// </summary>
    public class Code : Generator
    {
        /* Public methods. */
        public string Text { get; set; }

        /* Public methods. */
        public override string Generate()
        {
            return Text;
        }
    }
}
