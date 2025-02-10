namespace CSharpGenerator
{
    /// <summary>
    /// A base class for all type declaration generators (such as structs and classes).
    /// </summary>
    public abstract class TypeDeclaration : Member
    {
        /* Public properties. */
        /// <summary>
        /// The member generators of this type.
        /// </summary>
        public Member[] Members { get; private set; }
        /// <summary>
        /// The inheritance data of this type.
        /// </summary>
        public Inheritance Inheritance { get; private set; }

        /* Protected properties. */
        protected abstract string Category { get; }

        /* Constructors. */
        public TypeDeclaration(Summary summary, AttributeList attributes, ModifierList modifiers, Name name,
            Member[] members, Inheritance parent) : base(summary, attributes, modifiers, name)
        {
            Members = members ?? new Member[0];
            Inheritance = parent ?? new();
        }

        /* Public methods. */
        public override string Generate()
        {
            string contents = "";
            for (int i = 0; i < Members.Length; i++)
            {
                if (contents != "")
                    contents += "\n";
                contents += Members[i].Generate();
            }

            return $"{Summary.Generate("\n")}{Attributes.Generate("\n")}{Modifiers.Generate(" ")}{Category} {Name.Generate()}{Inheritance.Generate()}\n{new Block(contents).Generate()}";
        }
    }
}