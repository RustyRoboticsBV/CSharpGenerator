namespace CSharpGenerator
{
    /// <summary>
    /// A casting operator modifier generator.
    /// </summary>
    public class CastingModifier : GeneratorChoice<CastingModifierID>
    {
        /* Constructors. */
        public CastingModifier() : base() { }

        public CastingModifier(CastingModifier other) : base(other) { }

        public CastingModifier(CastingModifierID id) : base(id) { }

        /* Casting operators. */
        public static implicit operator CastingModifier(CastingModifierID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new CastingModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(CastingModifierID id)
        {
            switch (id)
            {
                case CastingModifierID.Explicit:
                    return "explicit";
                case CastingModifierID.Implicit:
                    return "implicit";
                default:
                    return "";
            }
        }
    }
}