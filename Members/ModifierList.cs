namespace CSharpGenerator
{
    /// <summary>
    /// A modifier keyword list generator.
    /// </summary>
    public abstract class ModifierList : Generator
    {
        /* Public properties. */
        public AccessModifier Access { get; set; } = AccessKeywordID.Public;

        /* Public methods. */
        public override string Generate()
        {
            return Access.Generate();
        }
    }
}