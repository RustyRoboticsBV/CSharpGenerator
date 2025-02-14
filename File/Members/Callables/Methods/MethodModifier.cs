namespace CSharpGenerator
{
    /// <summary>
    /// A method modifier generator.
    /// </summary>
    public class MethodModifier : GeneratorChoice<MethodModifierID>
    {
        /* Casting operators. */
        public static implicit operator MethodModifier(MethodModifierID ID)
        {
            return new()
            {
                ID = ID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(MethodModifierID ID)
        {
            switch (ID)
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
                default:
                    return "";
            }
        }
    }
}