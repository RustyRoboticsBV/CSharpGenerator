namespace CSharpGenerator
{
    /// <summary>
    /// Base class for all generators.
    /// </summary>
    public abstract class Generator
    {
        /* Public methods. */
        /// <summary>
        /// Generate C# code.
        /// </summary>
        public abstract string Generate();

        /// <summary>
        /// Generate C# code. If the generation did not return the empty string, attach the suffix.
        /// </summary>
        public string Generate(string suffix)
        {
            string code = Generate();
            if (code != "")
                return code + suffix;
            else
                return "";
        }
    }
}
