namespace CSharpGenerator
{
    /// <summary>
    /// A destructor generator.
    /// </summary>
    public class Destructor : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public string TypeName { get; set; } = "Name";
        public MethodImplementation Implementation { get; set; } = "";

        /* Public methods. */
        public override string Generate()
        {
            return $"{Summary.Generate("\n")}~{TypeName}()\n{Implementation.Generate()}";
        }
    }
}