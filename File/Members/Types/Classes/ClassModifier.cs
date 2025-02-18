namespace CSharpGenerator
{
    /// <summary>
    /// A class modifier generator.
    /// </summary>
    public class ClassModifier : GeneratorChoice<ClassModifierID>
    {
        /* Constructors. */
        public ClassModifier() : base() { }

        public ClassModifier(ClassModifier other) : base(other) { }

        public ClassModifier(ClassModifierID id) : base(id) { }

        /* Casting operators. */
        public static implicit operator ClassModifier(ClassModifierID id)
        {
            return new(id);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ClassModifier(this);
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(ClassModifierID id)
        {
            switch (id)
            {
                case ClassModifierID.Static:
                    return "static";
                case ClassModifierID.Abstract:
                    return "abstract";
                default:
                    return "";
            }
        }
    }
}