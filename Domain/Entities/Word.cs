namespace Domain.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Transcription { get; set; }
        public string? Image { get; set; }
        public Progress Progress { get; set; }
        public IList<Translation> Translations { get; set; } = new List<Translation>();
        public int WordListId { get; set; }
        public WordList WordList { get; set; }
    }
}
