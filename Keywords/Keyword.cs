namespace CSharpGenerator
{
    /// <summary>
    /// A keyword generator.
    /// </summary>
    public sealed class Keyword : Generator
    {
        /* Public properties. */
        public string Name { get; set; }

        /* Casting operators. */
        public static implicit operator Keyword(string name)
        {
            return new() { Name = name };
        }

        /* Public methods. */
        public override string Generate()
        {
            return Name;
        }
    }
}