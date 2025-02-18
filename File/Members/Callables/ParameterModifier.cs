namespace CSharpGenerator
{
    /// <summary>
    /// A parameter/argument pass keyword generator.
    /// </summary>
    public class ParameterModifier : GeneratorChoice<ParameterModifierID>
    {
        /* Constructors. */
        public ParameterModifier() { }

        public ParameterModifier(ParameterModifier other) : base(other) { }

        public ParameterModifier(ParameterModifierID id) : base(id) { }

        /* Casting operators. */
        public static implicit operator ParameterModifier(ParameterModifierID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ParameterModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(ParameterModifierID id)
        {
            switch (id)
            {
                case ParameterModifierID.In:
                    return "in";
                case ParameterModifierID.Out:
                    return "out";
                case ParameterModifierID.Ref:
                    return "ref";
                default:
                    return "";
            }
        }
    }
}