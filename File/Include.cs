namespace CSharpGenerator
{
    /// <summary>
    /// An include statement generator.
    /// </summary>
    public class Include : Generator
    {
        /* Public properties. */
        public string Namespace { get; set; }

        /* Casting operators. */
        public static implicit operator Include(string @namespace)
        {
            return new()
            {
                Namespace = @namespace
            };
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"using {Namespace};";
        }
    }
}