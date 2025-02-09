namespace CSharpGenerator
{
    /// <summary>
    /// A parameter generator, meant for method declaration.
    /// </summary>
    public sealed class Parameter : Generator
    {
        /* Public properties. */
        public Type Type { get; private set; }
        public Name Name { get; private set; }
        public Argument Default { get; private set; }

        /* Constructors. */
        public Parameter() : this("", "", "") { }

        public Parameter(Type type, Name name) : this(type, name, "") { }

        public Parameter(Type type, Name name, Argument @default)
        {
            Type = type ?? new();
            Name = name ?? new();
            Default = @default ?? new();
        }

        /* Conversion operators. */
        public static implicit operator Parameter((Type, Name) parameter)
        {
            return new(parameter.Item1, parameter.Item2);
        }

        public static implicit operator Parameter((Type, Name, Argument) parameter)
        {
            return new(parameter.Item1, parameter.Item2, parameter.Item3);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Type != "" && Name != "")
            {
                if (Default != "")
                    return $"{Type.Generate()} {Name.Generate()} = {Default.Generate()}";
                else
                    return $"{Type.Generate()} {Name.Generate()}";
            }
            else
                return "";
        }
    }
}