namespace CSharpGenerator
{
    /// <summary>
    /// An include statement generator.
    /// </summary>
    public class Using : Generator
    {
        /* Public properties. */
        public string Namespace { get; set; }

        /* Casting operators. */
        public static implicit operator Using(string @namespace)
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