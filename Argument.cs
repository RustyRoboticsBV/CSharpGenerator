namespace CSharpGenerator
{
    /// <summary>
    /// An argument generator.
    /// </summary>
    public sealed class Argument : Generator
    {
        /* Public properties. */
        public string Name { get; private set; }

        /* Constructors. */
        public Argument() : this("") { }

        public Argument(string name)
        {
            Name = name ?? "";
        }

        /* Conversion operators. */
        public static implicit operator Argument(string name)
        {
            return new(name);
        }

        public static implicit operator string(Argument argument)
        {
            return argument.Name;
        }

        /* Public methods. */
        public override string Generate()
        {
            return Name;
        }
    }
}