using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Words.Queries.GetAllWordsById
{
    public class WordDto : IMapFrom<Word>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Transcription { get; set; }
        public bool IsLearned { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Word, WordDto>()
                .ForMember(dest => dest.IsLearned, opt =>
                    opt.MapFrom(x => x.Progress.IsLearned));
        }
    }
}
