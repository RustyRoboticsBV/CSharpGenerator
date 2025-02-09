namespace CSharpGenerator
{
    /// <summary>
    /// A list of method modifier keywords.
    /// </summary>
    public sealed class MethodModifiers : Generator
    {
        /* Public properties. */
        public AccessModifier Access { get; private set; }
        public MethodOverrideModifier Override { get; private set; }
        public ReadonlyModifier Readonly { get; private set; }

        /* Constructors. */
        public MethodModifiers() : this(null, null, null) { }

        public MethodModifiers(AccessModifier access, MethodOverrideModifier @override, ReadonlyModifier @readonly)
        {
            if (access == null)
                access = new();
            if (@override == null)
                @override = new();
            if (@readonly == null)
                @readonly = new();

            Access = access;
            Override = @override;
            Readonly = @readonly;
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Access.Generate(" ")}{Override.Generate(" ")}{Readonly.Generate(" ")}";
        }
    }
}