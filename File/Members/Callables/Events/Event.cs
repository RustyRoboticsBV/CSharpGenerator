namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// An event generator.
    /// </summary>
    public class Event : Generator, IClassMember, IStructMember
    {
        /* Public properties. */
        public Summary Summary { get; set; } = "";
        public AttributeList Attributes { get; set; } = new();
        public AccessModifier Access { get; set; } = AccessID.Public;
        public string Delegate { get; set; } = "Action";
        public string Name { get; set; } = "Name";

        /* Construtors. */
        public Event() { }

        public Event(Event other)
        {
            Summary = new(other.Summary);
            Attributes = new(other.Attributes);
            Access = new(other.Access);
            Delegate = other.Delegate;
            Name = other.Name;
        }

        public Event(Summary summary, AttributeList attributes, AccessModifier access, string @delegate, string name)
        {
            Summary = summary;
            Attributes = attributes;
            Access = access;
            Delegate = @delegate;
            Name = name;
        }

        public Event(string @delegate, string name)
        {
            Delegate = @delegate;
            Name = name;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new Event(this);
        }

        public override string Generate()
        {
            return $"{Summary.Generate("\n")}{Attributes.Generate(" ")}{Access.Generate(" ")}event {Delegate} {Name};";
        }
    }
}