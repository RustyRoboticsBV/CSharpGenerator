namespace CSharpGenerator
{
    /// <summary>
    /// A class generator.
    /// </summary>
    public sealed class Class : TypeDeclaration
    {
        /* Protected properties. */
        protected override string Category => "class";

        /* Constructors. */
        public Class(Summary summary, AttributeList attributes, ClassModifierList modifiers, Name name, Inheritance inheritance,
            Member[] members) : base(summary, attributes, modifiers, name, members, inheritance) { }
    }
}