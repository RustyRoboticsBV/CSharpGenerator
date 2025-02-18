namespace CSharpGenerator
{
    /// <summary>
    /// A C# script file generator.
    /// </summary>
    public class File : Generator
    {
        /* Public properties. */
        public string Directory { get; set; } = "";
        public string Name { get; set; } = "";
        public UsingList Usings { get; set; } = new();
        public FileMemberList Members { get; set; } = new();

        /* Public methods. */
        public override string Generate()
        {
            return $"{Usings.Generate("\n\n")}{Members.Generate()}";
        }

        /// <summary>
        /// Generate & save this file.
        /// </summary>
        public void SaveToFile()
        {
            // Build filepath.
            string filePath = Name;
            if (Directory != "")
                filePath = $"{Directory}/{Name}";

            // Save to file.
            System.IO.File.WriteAllText(filePath, Members.Generate());
        }
    }
}