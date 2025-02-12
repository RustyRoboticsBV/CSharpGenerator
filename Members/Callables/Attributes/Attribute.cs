namespace CSharpGenerator
{
    /// <summary>
    /// A generator for adding an attribute to an object.
    /// </summary>
    public sealed class Attribute : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The name of the attribute.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// The arguments of the attribute.
        /// </summary>
        public ArgumentList Arguments { get; set; } = new();

        /* Casting operators. */
        public static implicit operator Attribute(string name)
        {
            return new()
            {
                Name = name
            };
        }

        public static implicit operator Attribute((string, ArgumentList) argument)
        {
            return new()
            {
                Name = argument.Item1,
                Arguments = argument.Item2
            };
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Arguments.Length == 0)
                return $"[{Name}]";
            else
                return $"[{Name}({Arguments.Generate()})]";
        }
    }
}