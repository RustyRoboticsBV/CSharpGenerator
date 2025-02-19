namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A generator that generates nothing.
    /// </summary>
    public class Empty : Generator, IFileMember, INamespaceMember, IClassMember, IStructMember, IInterfaceMember, IEnumMember
    {
        /* Public properties. */
        public static Empty Get => new();

        /* Public methods. */
        public override Generator Copy()
        {
            return new Empty();
        }

        public override string Generate()
        {
            return "";
        }
    }
}
