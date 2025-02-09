namespace CSharpGenerator
{
    /// <summary>
    /// A type generator.
    /// </summary>
    public sealed class Type : Generator
    {
        /* Public properties. */
        public Name Name { get; private set; }
        public bool Const { get; private set; }

        /* Constructors. */
        public Type() : this("") { }

        public Type(Name name, bool @const = false)
        {
            Name = name ?? new();
            Const = @const;
        }

        /* Conversion operators. */
        public static implicit operator Type(string name)
        {
            if (name.StartsWith("const "))
                return new(name.Substring(6), true);
            else
                return new(name, false);
        }

        public static implicit operator string(Type type)
        {
            return type.Name;
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Const)
                return "const " + Name.Generate();
            else
                return Name.Generate();
        }
    }
}