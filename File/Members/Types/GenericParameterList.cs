namespace CSharpGenerator
{
    /// <summary>
    /// A generic parameter list generator.
    /// </summary>
    public class GenericParameterList : ArgumentList
    {
        /* Constructors. */
        public GenericParameterList() : base() { }

        public GenericParameterList(Argument argumet) : base(argumet) { }

        public GenericParameterList(Argument[] argument) : base(argument) { }

        /* Casting operators. */
        public static implicit operator GenericParameterList(Argument argument)
        {
            return new(argument);
        }

        public static implicit operator GenericParameterList(Argument[] arguments)
        {
            return new(arguments);
        }

        public static implicit operator GenericParameterList(string argument)
        {
            return new Argument() { Value = argument };
        }

        public static implicit operator GenericParameterList(string[] arguments)
        {
            Argument[] result = new Argument[arguments.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arguments[i];
            }
            return result;
        }

        /* Public methods. */
        public override string Generate()
        {
            string code = base.Generate();
            if (code == "")
                return code;
            else
                return $"<{code}>";
        }
    }
}