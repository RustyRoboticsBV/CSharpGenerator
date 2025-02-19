namespace Rusty.CSharpGenerator
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

        /* Constructors. */
        public File() { }

        public File(File other)
        {
            Directory = other.Directory;
            Name = other.Name;
            Usings = new(other.Usings);
            Members = new(other.Members);
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new File(this);
        }

        public override string Generate()
        {
            return $"{Usings.Generate("\n\n")}{Members.Generate()}";
        }

        /// <summary>
        /// Generate & save this file.
        /// </summary>
        public void WriteToDisk()
        {
            // Build filepath.
            string filePath = Name;
            if (Directory != "")
                filePath = $"{Directory}/{Name}";

            // Save to file.
            System.IO.File.WriteAllText(filePath, Generate());
        }
    }
}