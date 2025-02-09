namespace CSharpGenerator
{
    /// <summary>
    /// A parameter list generator, meant for a method declarations.
    /// </summary>
    public sealed class ParameterList : Generator
    {
        /* Public properties. */
        /// <summary>
        /// The parameters in the list.
        /// </summary>
        public Parameter[] Parameters { get; private set; }
        /// <summary>
        /// The number of parameters.
        /// </summary>
        public int Length => Parameters.Length;

        /* Constructors. */
        public ParameterList() : this(null) { }

        public ParameterList(Parameter[] parameters)
        {
            if (parameters == null)
                parameters = new Parameter[0];

            Parameters = parameters;
        }

        /* Casting operators. */
        public static implicit operator ParameterList(Parameter[] parameters)
        {
            return new(parameters);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Parameters.Length == 0)
                return "";
            else
            {
                string argumentList = Parameters[0].Generate();
                for (int i = 1; i < argumentList.Length; i++)
                {
                    argumentList += $", {Parameters[i].Generate()}";
                }
                return argumentList;
            }
        }
    }
}