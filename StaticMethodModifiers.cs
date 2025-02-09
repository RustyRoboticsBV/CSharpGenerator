namespace CSharpGenerator
{
    /// <summary>
    /// A list of static method modifier keywords.
    /// </summary>
    public sealed class StaticMethodModifiers : ModifierList
    {
        /* Public properties. */
        public ReadonlyModifier Readonly { get; private set; }

        /* Constructors. */
        public StaticMethodModifiers() : this(null, null) { }

        public StaticMethodModifiers(AccessModifier access, ReadonlyModifier @readonly) : base(access)
        {
            Readonly = @readonly ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Access.Generate(" ")}{Readonly.Generate()}";
        }
    }
}