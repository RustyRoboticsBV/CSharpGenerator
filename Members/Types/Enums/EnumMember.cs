namespace CSharpGenerator
{
    /// <summary>
    /// An enum member generator.
    /// </summary>
    public class EnumMember : Generator, IEnumMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";

        /* Casting operators. */
        public static implicit operator EnumMember(string name)
        {
            return new()
            {
                Name = name
            };
        }

        /* Public methods. */
        public override string Generate()
        {
            string value = "";
            if (Value != "")
                value = $" = {Value}";
            return $"{Summary.Generate("\n")}{Name}{value}";
        }
    }
}
