namespace CSharpGenerator
{
    /// <summary>
    /// An access modifier generator.
    /// </summary>
    public class AccessModifier : GeneratorChoice<AccessID>
    {
        /* Casting operators. */
        public static implicit operator AccessModifier(AccessID ID)
        {
            return new()
            {
                ID = ID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(AccessID ID)
        {
            switch (ID)
            {
                case AccessID.Public:
                    return "public";
                case AccessID.Internal:
                    return "internal";
                case AccessID.Protected:
                    return "protected";
                case AccessID.Private:
                    return "private";
                case AccessID.ProtectedInternal:
                    return "protected internal";
                case AccessID.PrivateProtected:
                    return "private protected";
                case AccessID.File:
                    return "file";
                default:
                    return "";
            }
        }
    }
}