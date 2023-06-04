namespace Domain.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Transcription { get; set; }
        public string? Image { get; set; }
        public Progress Progress { get; set; }
        public IList<Translate> Translations { get; set; } = new List<Translate>();
    }
}
