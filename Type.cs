namespace CSharpGenerator
{
    /// <summary>
    /// A type generator.
    /// </summary>
    public sealed class Type : Generator
    {
        /* Public properties. */
        public string Name { get; private set; }

        /* Constructors. */
        public Type() : this("") { }

        public Type(string name)
        {
            Name = name ?? "";
        }

        /* Conversion operators. */
        public static implicit operator Type(string name)
        {
            return new(name);
        }

        public static implicit operator string(Type type)
        {
            return type.Name;
        }

        /* Public methods. */
        public override string Generate()
        {
            return Name;
        }
    }
}