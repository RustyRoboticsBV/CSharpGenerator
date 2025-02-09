namespace CSharpGenerator
{
    /// <summary>
    /// A modifier keyword list generator.
    /// </summary>
    public abstract class ModifierList : Generator
    {
        /* Public properties. */
        public AccessModifier Access { get; private set; }

        /* Constructors. */
        public ModifierList(AccessModifier access)
        {
            Access = access;
        }

        /* Public methods. */
        public override string Generate()
        {
            return Access.Generate();
        }
    }
}