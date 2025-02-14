namespace CSharpGenerator
{
    /// <summary>
    /// A parameter list generator, meant for a method declarations.
    /// </summary>
    public class ParameterList : GeneratorList<Parameter>
    {
        /* Protected methods. */
        protected override string Separator => ", ";

        /* Casting operators. */
        public static implicit operator ParameterList(Parameter[] parameters)
        {
            return new() { Elements = parameters };
        }

        public static implicit operator ParameterList(Parameter parameter)
        {
            return new Parameter[] { parameter };
        }
    }
}