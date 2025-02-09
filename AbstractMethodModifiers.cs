namespace CSharpGenerator
{
    /// <summary>
    /// A list of static method modifier keywords.
    /// </summary>
    public sealed class AbstractMethodModifiers : ModifierList
    {
        /* Constructors. */
        public AbstractMethodModifiers() : this(null) { }

        public AbstractMethodModifiers(AccessModifier access) : base(access) { }
    }
}