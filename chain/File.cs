namespace worksheet_eight_behavioural_design_patterns
{
    /// <summary>
    /// This is just a dummy class rather than using a real class - a mock.
    /// </summary>
    public class File
    {
        public string FileName { get; }
        public string Type { get; }
        public string Location { get; }

        public File(string fileName, string type, string location)
        {
            FileName = fileName;
            Type = type;
            Location = location;
        }  
    }
}