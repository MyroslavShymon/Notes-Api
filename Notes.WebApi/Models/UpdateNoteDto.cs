using System;
using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.UpdateNote;

namespace Notes.WebApi.Models
{
    public class UpdateNoteDto : IMapWith<UpdateNoteCommand>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Color { get; set; }
        public bool Pin { get; set; }
        public DateTime? Deadline { get; set; }
        public string Group { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateNoteDto, UpdateNoteCommand>()
                .ForMember(noteCommand => noteCommand.Id,
                    opt => opt.MapFrom(noteDto => noteDto.Id))
                .ForMember(noteCommand => noteCommand.Title,
                    opt => opt.MapFrom(noteDto => noteDto.Title))
                .ForMember(noteCommand => noteCommand.Details,
                    opt => opt.MapFrom(noteDto => noteDto.Details))
                .ForMember(noteCommand => noteCommand.Color,
                    opt => opt.MapFrom(noteDto => noteDto.Color))
                .ForMember(noteCommand => noteCommand.Pin,
                    opt => opt.MapFrom(noteDto => noteDto.Pin))
                .ForMember(noteCommand => noteCommand.Deadline,
                    opt => opt.MapFrom(noteDto => noteDto.Deadline))
                .ForMember(noteCommand => noteCommand.Group,
                    opt => opt.MapFrom(noteDto => noteDto.Group));
        }
    }
}