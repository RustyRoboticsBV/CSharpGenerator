namespace CSharpGenerator
{
    /// <summary>
    /// A parameter/argument pass keyword generator.
    /// </summary>
    public class ParameterModifier : GeneratorChoice<ParameterModifierID>
    {
        /* Casting operators. */
        public static implicit operator ParameterModifier(ParameterModifierID ID)
        {
            return new()
            {
                ID = ID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(ParameterModifierID ID)
        {
            switch (ID)
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