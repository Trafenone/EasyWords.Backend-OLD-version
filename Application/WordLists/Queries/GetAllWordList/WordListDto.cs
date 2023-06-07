using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.WordLists.Queries.GetAllWordList
{
    public class WordListDto : IMapFrom<WordList>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WordList, WordListDto>();
        }
    }
}
