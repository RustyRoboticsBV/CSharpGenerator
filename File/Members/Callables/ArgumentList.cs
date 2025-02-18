namespace CSharpGenerator
{
    /// <summary>
    /// An argument list generator, meant for a function call or attribute use.
    /// </summary>
    public class ArgumentList : GeneratorList<Argument>
    {
        /* Constructors. */
        public ArgumentList() : base() { }

        public ArgumentList(Argument argumet) : base(argumet) { }

        public ArgumentList(Argument[] argument) : base(argument) { }

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
            return new Argument() { Value = argument };
        }

        public static implicit operator ArgumentList(string[] arguments)
        {
            Argument[] result = new Argument[arguments.Length];
            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = arguments[i];
            }
            return result;
        }
    }
}