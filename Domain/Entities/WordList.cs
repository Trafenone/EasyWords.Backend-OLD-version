namespace Domain.Entities
{
    public class WordList
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Word> Words { get; set; } 
    }
}
