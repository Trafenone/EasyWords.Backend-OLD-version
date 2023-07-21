namespace Domain.Entities
{
    public class Word
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Transcription { get; set; }
        public string? Image { get; set; }
        public Progress Progress { get; set; }
        public ICollection<Translation> Translations { get; set; }
        public Guid WordListId { get; set; }
        public WordList WordList { get; set; }
    }
}
