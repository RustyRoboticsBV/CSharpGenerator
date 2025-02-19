namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A field modifier generator.
    /// </summary>
    public class FieldModifier : GeneratorChoice<FieldModifierID>
    {
        /* Constructors. */
        public FieldModifier() : base() { }

        public FieldModifier(FieldModifier other) : base(other) { }

        public FieldModifier(FieldModifierID id) : base(id) { }

        public FieldModifier(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator FieldModifier(FieldModifierID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new FieldModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(FieldModifierID id)
        {
            switch (id)
            {
                case FieldModifierID.Const:
                    return "const";
                case FieldModifierID.Readonly:
                    return "readonly";
                case FieldModifierID.Static:
                    return "static";
                default:
                    return "";
            }
        }
    }
}