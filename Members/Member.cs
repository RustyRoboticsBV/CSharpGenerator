namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all method declaration generators.
    /// </summary>
    public abstract class Member<T> : Identifier where T : ModifierList, new()
    {
        /* Public properties. */
        /// <summary>
        /// The modifiers of this member.
        /// </summary>
        public T Modifiers { get; private set; }

        /* Constructors. */
        public Member(Summary summary, AttributeList attributes, T modifiers, Name name)
            : base(summary, attributes, name)
        {
            Modifiers = modifiers ?? new();
        }
    }
}