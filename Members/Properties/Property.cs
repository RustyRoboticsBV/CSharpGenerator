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
        public Property(Summary summary, AttributeList attributes, MethodModifiers modifiers, Name name)
            : this(summary, attributes, modifiers, name, new AutoGetter(), new AutoSetter()) { }

        public Property(Summary summary, AttributeList attributes, MethodModifiers modifiers, Name name, string fieldName)
            : this(summary, attributes, modifiers, name, new FieldGetter(fieldName), new FieldSetter(fieldName)) { }

        public Property(Summary summary, AttributeList attributes, MethodModifiers modifiers, Name name, Getter getter,
            Setter setter) : base(summary, attributes, modifiers ?? new(), name)
        {
            Getter = getter ?? new AutoGetter();
            Setter = setter ?? new AutoSetter();
        }

        /* Public methods. */
        public override string Generate()
        {
            string getter = Getter.Generate();
            string setter = Setter.Generate();
            if (getter == "get;" && setter == "set;")
            {
                string implementation = $"{'{'} {getter} {setter} {'}'}";
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Modifiers.Generate(" ")}{Name.Generate(" ")}{implementation}";
            }
            else
            {
                Block implementation = new Block(getter + "\n" + setter);
                return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Modifiers.Generate(" ")}{Name.Generate("\n")}{implementation.Generate()}";
            }
        }
    }
}