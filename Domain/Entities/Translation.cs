namespace Domain.Entities
{
    public class Translation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Example { get; set; }
        public string PartOfSpeech { get; set; }
        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
