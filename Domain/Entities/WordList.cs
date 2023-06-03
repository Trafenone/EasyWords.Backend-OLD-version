namespace Domain.Entities
{
    public class WordList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public IList<Word> Words { get; set; } = new List<Word>();
    }
}
