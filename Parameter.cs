namespace CSharpGenerator
{
    /// <summary>
    /// A parameter generator, meant for method declaration.
    /// </summary>
    public sealed class Parameter : Generator
    {
        /* Public properties. */
        public string Name { get; private set; }
        public string Value { get; private set; }

        /* Constructors. */
        public Parameter() : this("", "") { }

        public Parameter(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /* Casting operators. */
        public static implicit operator Parameter((string, string) parameter)
        {
            return new(parameter.Item1, parameter.Item2);
        }

        /* Public methods. */
        public override string Generate()
        {
            return $"{Name} {Value}";
        }
    }
}