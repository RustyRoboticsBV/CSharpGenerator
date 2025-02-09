namespace CSharpGenerator
{
    /// <summary>
    /// A property generator. */
    /// </summary>
    public class Property : Member
    {
        /* Public properties. */
        public Getter Getter { get; private set; }
        public Setter Setter { get; private set; }

        /* Constructors. */
        public Property(Summary summary, AttributeList attributes, MethodModifiers modifiers, Name name, Getter getter,
            Setter setter) : base(summary, attributes, modifiers ?? new(), name)
        {
            Getter = getter;
            Setter = setter;
        }

        /* Public methods. */
        public override string Generate()
        {
            string getter = Getter.Generate();
            string setter = Setter.Generate();
            Block implementation = new Block(getter + "\n" + setter);
            return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Modifiers.Generate(" ")}{Name.Generate("\n")}{implementation.Generate()}";
        }
    }
}