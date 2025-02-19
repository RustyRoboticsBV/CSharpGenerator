namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A class modifier generator.
    /// </summary>
    public class StructModifier : GeneratorChoice<StructModifierID>
    {
        /* Constructors. */
        public StructModifier() : base() { }

        public StructModifier(StructModifier other) : base(other) { }

        public StructModifier(StructModifierID id) : base(id) { }

        public StructModifier(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator StructModifier(StructModifierID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new StructModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(StructModifierID ID)
        {
            switch (ID)
            {
                case StructModifierID.Static:
                    return "static";
                case StructModifierID.Readonly:
                    return "readonly";
                default:
                    return "";
            }
        }
    }
}