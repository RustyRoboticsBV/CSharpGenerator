namespace CSharpGenerator
{
    /// <summary>
    /// A list of method modifier keywords.
    /// </summary>
    public sealed class MethodModifiers : ModifierList
    {
        /* Public properties. */
        public MethodOverrideModifier Override { get; private set; }
        public ReadonlyModifier Readonly { get; private set; }

        /* Constructors. */
        public MethodModifiers() : this(null, null, null) { }

        public MethodModifiers(AccessModifier access, MethodOverrideModifier @override, ReadonlyModifier @readonly)
            : base(access)
        {
            Override = @override ?? new();
            Readonly = @readonly ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Access.Generate(" ")}{Override.Generate(" ")}{Readonly.Generate()}";
        }
    }
}