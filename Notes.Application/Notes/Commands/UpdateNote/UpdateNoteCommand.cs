using System;
using MediatR;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommand :IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Color { get; set; }
        public bool Pin { get; set; }
        public DateTime? Deadline { get; set; }
        public string Group { get; set; }
    }
}