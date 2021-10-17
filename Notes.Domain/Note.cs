using System;

namespace Notes.Domain
{
    public class Note
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Group { get; set; }
        public string Color { get; set; }
        public bool Pin { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? EditDate { get; set; }
    }
}