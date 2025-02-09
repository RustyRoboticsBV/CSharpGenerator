namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all method declaration generators.
    /// </summary>
    public abstract class Member : Identifier
    {
        /* Public properties. */
        /// <summary>
        /// The modifiers of this member.
        /// </summary>
        public ModifierList Modifiers { get; private set; }

        /* Constructors. */
        public Member(Summary summary, AttributeList attributes, ModifierList modifiers, Name name)
            : base(summary, attributes, name)
        {
            Modifiers = modifiers;
        }
    }
}