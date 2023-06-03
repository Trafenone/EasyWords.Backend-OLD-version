namespace Domain.ValueObjects
{
    public class Progress
    {
        public DateTime CreationDate { get; set; }
        public DateTime? LastTrainingDate { get; set; }
        public bool IsLearned { get; set; }
    }
}
