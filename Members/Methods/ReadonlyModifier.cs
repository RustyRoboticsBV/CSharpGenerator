namespace CSharpGenerator
{
    /// <summary>
    /// A read-only keyword generator.
    /// </summary>
    public class ReadonlyModifier : GeneratorOption<Keyword>
    {
        /* Public properties. */
        public override Generator Generator => new Keyword("readonly");

        /* Constructors. */
        public ReadonlyModifier() : this(true) { }

        public ReadonlyModifier(bool enabled) : base(enabled) { }
    }
}