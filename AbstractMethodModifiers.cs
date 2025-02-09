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

        /* Conversion operators. */
        public static implicit operator AbstractMethodModifiers(AccessModifier modifiers)
        {
            return new(modifiers);
        }
    }
}