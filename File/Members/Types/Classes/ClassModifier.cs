namespace CSharpGenerator
{
    /// <summary>
    /// A class modifier generator.
    /// </summary>
    public class ClassModifier : GeneratorChoice<ClassModifierID>
    {
        /* Casting operators. */
        public static implicit operator ClassModifier(ClassModifierID ID)
        {
            return new()
            {
                ID = ID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(ClassModifierID ID)
        {
            switch (ID)
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