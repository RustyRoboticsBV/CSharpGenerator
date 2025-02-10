namespace CSharpGenerator
{
    /// <summary>
    /// The modifiers of a class.
    /// </summary>
    public sealed class ClassModifierList : ModifierList
    {
        public ClassModifierList(AccessModifier access) : base(access) { }

        /* Casting operators. */
        public static implicit operator ClassModifierList(AccessKeywordID access)
        {
            return new ClassModifierList(access);
        }
    }
}
