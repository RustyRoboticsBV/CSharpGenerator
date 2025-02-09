namespace CSharpGenerator
{
    /// <summary>
    /// An user-defined property setter generator.
    /// </summary>
    public class CustomSetter : Setter
    {
        /* Public properties. */
        public Block Implementation { get; private set; }

        /* Constructors. */
        public CustomSetter() : this(null) { }

        public CustomSetter(Block implementation) : base()
        {
            Implementation = implementation ?? "";
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Implementation == "")
                return "set;";
            else
                return $"set\n{Implementation.Generate()}";
        }
    }
}