namespace CSharpGenerator
{
    /// <summary>
    /// An auto-implemented property getter generator.
    /// </summary>
    public class AutoGetter : Getter
    {
        /* Public properties. */
        public Name Field { get; private set; }

        /* Constructors. */
        public AutoGetter() : this(null) { }

        public AutoGetter(Name field) : base()
        {
            Field = field ?? "";
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Field == null)
                return "get;";
            else
                return $"get => {Field.Generate()};";
        }
    }
}