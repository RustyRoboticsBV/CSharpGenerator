namespace CSharpGenerator
{
    /// <summary>
    /// A static method declaration.
    /// </summary>
    public class StaticMethod : BaseMethod<StaticMethodModifiers>
    {
        /* Constructors. */
        public StaticMethod() : this(null, null, null, null, null, null, null) { }

        public StaticMethod(Summary summary, AttributeList attributes, StaticMethodModifiers modifiers, Type returnType,
            Name name, ParameterList parameters, Block implementation)
            : base(summary, attributes, modifiers, returnType, name, parameters, implementation) { }
    }
}