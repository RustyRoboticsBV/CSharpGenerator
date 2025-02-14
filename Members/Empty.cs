namespace CSharpGenerator
{
    /// <summary>
    /// A generator that generates nothing.
    /// </summary>
    public class Empty : Generator, IClassMember, IStructMember, IEnumMember, INamespaceMember
    {
        /* Public methods. */
        public override string Generate()
        {
            return "";
        }
    }
}
