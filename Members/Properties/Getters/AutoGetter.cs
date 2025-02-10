namespace CSharpGenerator
{
    /// <summary>
    /// An automatic property getter generator.
    /// </summary>
    public class AutoGetter : Getter
    {
        /* Constructors. */
        public AutoGetter() { }

        /* Public methods. */
        public override string Generate()
        {
            return "get;";
        }
    }
}