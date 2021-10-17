using System;
using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteLookupDto: IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Group { get; set; }
        public string Color { get; set; }
        public bool Pin { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDto => noteDto.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(noteDto => noteDto.Title,
                    opt => opt.MapFrom(note => note.Title))
                .ForMember(noteDto => noteDto.Group,
                    opt => opt.MapFrom(note => note.Group))
                .ForMember(noteDto => noteDto.Color,
                    opt => opt.MapFrom(note => note.Color))
                .ForMember(noteDto => noteDto.Pin,
                    opt => opt.MapFrom(note => note.Pin))
                .ForMember(noteDto => noteDto.Details,
                    opt => opt.MapFrom(note => note.Details))
                .ForMember(noteDto => noteDto.CreationDate,
                    opt => opt.MapFrom(note => note.CreationDate))
                .ForMember(noteDto => noteDto.Deadline,
                    opt => opt.MapFrom(note => note.Deadline))
                .ForMember(noteDto => noteDto.EditDate,
                    opt => opt.MapFrom(note => note.EditDate));

        }
    }
}