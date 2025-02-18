namespace CSharpGenerator
{
    /// <summary>
    /// An access modifier generator.
    /// </summary>
    public class AccessModifier : GeneratorChoice<AccessID>
    {
        /* Constructors. */
        public AccessModifier() : base() { }

        public AccessModifier(AccessModifier other) : base(other) { }

        public AccessModifier(AccessID id) : base(id) { }

        public AccessModifier(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator AccessModifier(string id)
        {
            return new(id);
        }

        public static implicit operator AccessModifier(AccessID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new AccessModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(AccessID id)
        {
            switch (id)
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