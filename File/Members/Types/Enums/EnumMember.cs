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

        /* Constructors. */
        public EnumMember() { }

        public EnumMember(EnumMember other)
        {
            Summary = new(other.Summary);
            Name = other.Name;
            Value = other.Value;
        }

        public EnumMember(string name, string value = "")
        {
            Name = name;
            Value = value;
        }

        public EnumMember(Summary summary, string name, string value = "")
        {
            Summary = summary;
            Name = name;
            Value = value;
        }

        /* Casting operators. */
        public static implicit operator EnumMember(string name)
        {
            return new(name);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new EnumMember(this);
        }

        public override string Generate()
        {
            string value = "";
            if (Value != "")
                value = $" = {Value}";
            return $"{Summary.Generate("\n")}{Name}{value}";
        }
    }
}
