namespace ConsoleAppReadingAppSettingsJSON
{
    public class AppSettings
    {
        public bool InMemory { get; set; }
        public bool IsProduction { get; set; }
        public string Title { get; set; }
        public int SumNumber { get; set; }
        public Arthor Arthor { get; set; }
    }
    public class Arthor
    {
        public string Name { get; set; }
        public int SumNumber { get; set; }
    }
}

