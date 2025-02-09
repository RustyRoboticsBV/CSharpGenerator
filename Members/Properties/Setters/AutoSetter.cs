namespace CSharpGenerator
{
    /// <summary>
    /// An auto-implemented property setter generator.
    /// </summary>
    public class AutoSetter : Setter
    {
        /* Public properties. */
        public Name Field { get; private set; }

        /* Constructors. */
        public AutoSetter() : this(null) { }

        public AutoSetter(Name field) : base()
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