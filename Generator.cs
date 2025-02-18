namespace CSharpGenerator
{
    /// <summary>
    /// Base class for all generators.
    /// </summary>
    public abstract class Generator
    {
        /* Public methods */
        /// <summary>
        /// Whether or not this generator generates to the empty string.
        /// </summary>
        public bool IsEmpty => Generate() == "";

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

        /// <summary>
        /// Generate C# code. If the generation did not return the empty string, attach the prefix and suffix.
        /// </summary>
        public string Generate(string prefix, string suffix)
        {
            string code = Generate(suffix);
            if (code != "")
                return prefix + code;
            else
                return "";
        }
    }
}
