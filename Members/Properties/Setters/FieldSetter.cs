namespace CSharpGenerator
{
    /// <summary>
    /// An auto-implemented property setter generator.
    /// </summary>
    public class FieldSetter : Setter
    {
        /* Public properties. */
        public Name Field { get; private set; }

        /* Constructors. */
        public FieldSetter() : this(null) { }

        public FieldSetter(Name field) : base()
        {
            Field = field ?? "";
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Field == null)
                return "set;";
            else
                return $"set => {Field.Generate()} = value;";
        }
    }
}