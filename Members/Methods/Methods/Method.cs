namespace CSharpGenerator
{
    /// <summary>
    /// A non-static, non-abstract method declaration generator.
    /// </summary>
    public class Method : BaseMethod<MethodModifiers>
    {
        public Method() : this(null, null, null, null, null, null, null) { }

        public Method(Summary summary, AttributeList attributes, MethodModifiers modifiers, Type returnType, Name name,
            ParameterList parameters, Block implementation)
            : base(summary, attributes, modifiers, returnType, name, parameters, implementation) { }
    }
}