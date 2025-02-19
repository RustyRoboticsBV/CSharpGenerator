namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A property modifier generator.
    /// </summary>
    public class PropertyModifier : GeneratorChoice<PropertyModifierID>
    {
        /* Constructors. */
        public PropertyModifier() : base() { }

        public PropertyModifier(PropertyModifier other) : base(other) { }

        public PropertyModifier(PropertyModifierID id) : base(id) { }

        public PropertyModifier(string id) : base(id) { }

        /* Casting operators. */
        public static implicit operator PropertyModifier(PropertyModifierID id)
        {
            return new(id);
        }

        /* Public propertys. */
        public override Generator Copy()
        {
            return new PropertyModifier(this);
        }

        /* Protected propertys. */
        protected override Keyword GetKeyword(PropertyModifierID id)
        {
            switch (id)
            {
                case PropertyModifierID.Static:
                    return "static";
                case PropertyModifierID.StaticNew:
                    return "static new";
                case PropertyModifierID.Abstract:
                    return "abstract";
                case PropertyModifierID.Virtual:
                    return "virtual";
                case PropertyModifierID.Override:
                    return "override";
                case PropertyModifierID.OverrideSealed:
                    return "override sealed";
                case PropertyModifierID.New:
                    return "new";
                case PropertyModifierID.NewVirtual:
                    return "new virtual";
                case PropertyModifierID.Readonly:
                    return "readonly";
                default:
                    return "";
            }
        }
    }
}