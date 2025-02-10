﻿namespace CSharpGenerator
{
    /// <summary>
    /// A summary comment generator.
    /// </summary>
    public sealed class Summary : Comment
    {
        /* Constructors. */
        public Summary() : this(null) { }

        public Summary(string text) : base(text) { }

        /* Conversion operators. */
        public static implicit operator Summary(string text)
        {
            return new(text);
        }

        /* Public methods. */
        public override string Generate()
        {
            if (Text == "")
                return "";
            else
                return $"/// <summary>\n/// {Text.Replace("\n", "\n/// ")}\n/// </summary>";
        }
    }
}