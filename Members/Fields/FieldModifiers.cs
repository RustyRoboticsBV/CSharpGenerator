namespace CSharpGenerator
{
    /// <summary>
    /// A list of static method modifier keywords.
    /// </summary>
    public sealed class FieldModifiers : ModifierList
    {
        /* Constructors. */
        public FieldModifiers() : this(null) { }

        public FieldModifiers(AccessModifier access) : base(access) { }

        /* Conversion operators. */
        public static implicit operator FieldModifiers(AccessModifier modifiers)
        {
            return new(modifiers);
        }

        public static implicit operator FieldModifiers(AccessKeywordID access)
        {
            return new((AccessModifier)access);
        }
    }
}