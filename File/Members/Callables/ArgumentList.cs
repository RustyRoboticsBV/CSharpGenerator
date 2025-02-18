namespace CSharpGenerator
{
    /// <summary>
    /// An argument list generator, meant for a function call or attribute use.
    /// </summary>
    public class ArgumentList : GeneratorList<Argument>
    {
        /* Constructors. */
        public ArgumentList() : base() { }

        public ArgumentList(ArgumentList other) : base(other) { }

        public ArgumentList(Argument argumet) : base(argumet) { }

        public ArgumentList(params Argument[] arguments) : base(arguments) { }

        public ArgumentList(string argument) : base(argument) { }

        public ArgumentList(params string[] arguments) : base()
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                Elements.Add(arguments[i]);
            }
        }

        /* Casting operators. */
        public static implicit operator ArgumentList(Argument argument)
        {
            return new(argument);
        }

        public static implicit operator ArgumentList(Argument[] arguments)
        {
            return new(arguments);
        }

        public static implicit operator ArgumentList(string argument)
        {
            return new(argument);
        }

        public static implicit operator ArgumentList(string[] arguments)
        {
            return new(arguments);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ArgumentList(this);
        }
    }
}