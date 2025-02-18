namespace CSharpGenerator
{
    /// <summary>
    /// A generic constraint list generator.
    /// </summary>
    public class GenericConstraintList : GeneratorList<GenericConstraint>
    {
        /* Protected properties */
        protected override string Separator => "\n";

        /* Constructors. */
        public GenericConstraintList() : base() { }

        public GenericConstraintList(GenericConstraintList other) : base(other) { }

        public GenericConstraintList(GenericConstraint argumet) : base(argumet) { }

        public GenericConstraintList(GenericConstraint[] argument) : base(argument) { }

        /* Casting operators. */
        public static implicit operator GenericConstraintList(GenericConstraint argument)
        {
            return new(argument);
        }

        public static implicit operator GenericConstraintList(GenericConstraint[] arguments)
        {
            return new(arguments);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new GenericConstraintList(this);
        }

        public override string Generate()
        {
            string code = base.Generate();
            if (code == "")
                return "";
            else
            {
                if (code.Contains('\n'))
                    return $"\n    {code.Replace("\n", "\n    ")}";
                else
                    return $" {code}";
            }
        }
    }
}