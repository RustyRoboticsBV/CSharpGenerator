namespace Rusty.CSharpGenerator
{
    /// <summary>
    /// A method override modifier keyword id.
    /// </summary>
    public enum MethodModifierID
    {
        None,
        Static,
        StaticNew,
        Abstract,
        Virtual,
        Override,
        OverrideSealed,
        New,
        NewVirtual,
        Readonly,
        OverrideReadonly
    }
}