namespace CSharpGenerator
{
    /// <summary>
    /// A class modifier generator.
    /// </summary>
    public class StructModifier : GeneratorChoice<StructModifierID>
    {
        /* Casting operators. */
        public static implicit operator StructModifier(StructModifierID ID)
        {
            return new()
            {
                ID = ID
            };
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