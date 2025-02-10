namespace CSharpGenerator
{
    /// <summary>
    /// An auto-implemented property getter generator.
    /// </summary>
    public class FieldGetter : Getter
    {
        /* Public properties. */
        public Name Field { get; private set; }

        /* Constructors. */
        public FieldGetter() : this(null) { }

        public FieldGetter(Name field) : base()
        {
            Field = field ?? "";
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Field.Text == "")
                return "get;";
            else
                return $"get => {Field.Generate()};";
        }
    }
}