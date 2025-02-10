namespace CSharpGenerator
{
    /// <summary>
    /// An user-defined property getter generator.
    /// </summary>
    public class CustomGetter : Getter
    {
        /* Public properties. */
        public Block Implementation { get; private set; }

        /* Constructors. */
        public CustomGetter() : this(null) { }

        public CustomGetter(Block implementation) : base()
        {
            Implementation = implementation ?? "";
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Implementation.Contents == "")
                return "get;";
            else
                return $"get\n{Implementation.Generate()}";
        }
    }
}