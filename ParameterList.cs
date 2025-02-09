namespace CSharpGenerator
{
    /// <summary>
    /// A parameter list generator, meant for a method declarations.
    /// </summary>
    public sealed class ParameterList : GeneratorList<Parameter>
    {
        /* Protected methods. */
        protected override string Separator => ", ";

        /* Constructors. */
        public ParameterList() : this(null) { }

        public ParameterList(Parameter[] parameters) : base(parameters) { }

        /* Casting operators. */
        public static implicit operator ParameterList(Parameter[] parameters)
        {
            return new(parameters);
        }
    }
}