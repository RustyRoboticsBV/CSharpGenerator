namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// An operator generator.
    /// </summary>
    public abstract class Operator : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public MethodImplementation Implementation { get; set; } = "";

        /* Constructors. */
        public Operator() { }

        public Operator(Operator other)
        {
            Summary = other.Summary;
            Implementation = other.Implementation;
        }
    }
}