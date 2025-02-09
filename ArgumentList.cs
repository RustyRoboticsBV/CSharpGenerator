namespace CSharpGenerator
{
    /// <summary>
    /// An argument list generator, meant for a function call or attribute use.
    /// </summary>
    public sealed class ArgumentList : GeneratorList<Argument>
    {
        /* Protected methods. */
        protected override string Separator => ", ";

        /* Constructors. */
        public ArgumentList() : this(null) { }

        public ArgumentList(Argument[] arguments) : base(arguments) { }

        /* Casting operators. */
        public static implicit operator ArgumentList(Argument[] arguments)
        {
            return new(arguments);
        }

        public static implicit operator ArgumentList(Argument argument)
        {
            return new(new Argument[1] { argument });
        }
    }
}