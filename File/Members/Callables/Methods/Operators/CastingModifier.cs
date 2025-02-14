using System;

namespace CSharpGenerator
{
    /// <summary>
    /// A casting operator modifier generator.
    /// </summary>
    public class CastingModifier : GeneratorChoice<CastingModifierID>
    {
        /* Casting operators. */
        public static implicit operator CastingModifier(CastingModifierID ID)
        {
            return new()
            {
                ID = ID
            };
        }

        /* Protected methods. */
        protected override Keyword GetKeyword(CastingModifierID ID)
        {
            switch (ID)
            {
                case CastingModifierID.Explicit:
                    return "explicit";
                case CastingModifierID.Implicit:
                    return "implicit";
                default:
                    throw new ArgumentException();
            }
        }
    }
}