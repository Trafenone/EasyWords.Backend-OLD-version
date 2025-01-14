﻿namespace Domain.Entities
{
    public class Progress
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastTrainingDate { get; set; }
        public bool IsLearned { get; set; }
        public Word Word { get; set; }
    }
}
