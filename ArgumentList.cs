namespace CSharpGenerator
{
    /// <summary>
    /// An argument list generator, meant for a function call or attribute use.
    /// </summary>
    public sealed class ArgumentList : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The arguments of the attribute.
        /// </summary>
        public string[] Arguments { get; private set; }
        /// <summary>
        /// The number of arguments.
        /// </summary>
        public int Length => Arguments.Length;

        /* Constructors. */
        public ArgumentList() : this(null) { }

        public ArgumentList(string[] arguments)
        {
            if (arguments == null)
                arguments = new string[0];

            Arguments = arguments;
        }

        /* Casting operators. */
        public static implicit operator ArgumentList(string[] arguments)
        {
            return new(arguments);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Arguments.Length == 0)
                return "";
            else
            {
                string argumentList = Arguments[0];
                for (int i = 1; i < argumentList.Length; i++)
                {
                    argumentList += $", {Arguments[i]}";
                }
                return argumentList;
            }
        }
    }
}