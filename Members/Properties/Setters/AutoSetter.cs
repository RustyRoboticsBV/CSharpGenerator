namespace CSharpGenerator
{
    /// <summary>
    /// An automatic property setter generator.
    /// </summary>
    public class AutoSetter : Setter
    {
        /* Constructors. */
        public AutoSetter() { }

        /* Public methods. */
        public override string Generate()
        {
            return "set;";
        }
    }
}