namespace CSharpGenerator
{
    /// <summary>
    /// An abstract method declaration.
    /// </summary>
    public class AbstractMethod : BaseMethod<AbstractMethodModifiers>
    {
        /* Constructors. */
        public AbstractMethod() : this(null, null, null, null, null, null) { }

        public AbstractMethod(Summary summary, AttributeList attributes, AbstractMethodModifiers modifiers, Type returnType,
            Name name, ParameterList parameters)
            : base(summary, attributes, modifiers, returnType, name, parameters, null) { }
    }
}