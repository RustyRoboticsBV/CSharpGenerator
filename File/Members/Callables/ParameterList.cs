namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A parameter list generator, meant for a method declarations.
    /// </summary>
    public class ParameterList : GeneratorList<Parameter>
    {
        /* Protected methods. */
        protected override string Separator => ", ";

        /* Constructors. */
        public ParameterList() : base() { }

        public ParameterList(ParameterList other) : base(other) { }

        public ParameterList(Parameter parameter) : base(parameter) { }

        public ParameterList(Parameter[] parameters) : base(parameters) { }

        /* Casting operators. */
        public static implicit operator ParameterList(Parameter parameter)
        {
            return new(parameter);
        }

        public static implicit operator ParameterList(Parameter[] parameters)
        {
            return new(parameters);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new ParameterList(this);
        }
    }
}