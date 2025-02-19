namespace CSharpGenerator
{
    /// <summary>
    /// A method modifier generator.
    /// </summary>
    public class MethodModifier : GeneratorChoice<MethodModifierID>
    {
        /* Constructors. */
        public MethodModifier() : base() { }

        public MethodModifier(MethodModifier other) : base(other) { }

        public MethodModifier(MethodModifierID id) : base(id) { }

        public MethodModifier(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator MethodModifier(MethodModifierID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new MethodModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(MethodModifierID id)
        {
            switch (id)
            {
                case MethodModifierID.Static:
                    return "static";
                case MethodModifierID.StaticNew:
                    return "static new";
                case MethodModifierID.Abstract:
                    return "abstract";
                case MethodModifierID.Virtual:
                    return "virtual";
                case MethodModifierID.Override:
                    return "override";
                case MethodModifierID.OverrideSealed:
                    return "override sealed";
                case MethodModifierID.New:
                    return "new";
                case MethodModifierID.NewVirtual:
                    return "new virtual";
                case MethodModifierID.Readonly:
                    return "readonly";
                case MethodModifierID.OverrideReadonly:
                    return "override readonly";
                default:
                    return "";
            }
        }
    }
}