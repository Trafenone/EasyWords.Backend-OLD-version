using Application.Interfaces.Base;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IRepository<Word> _wordRepository;

        public WordController(IRepository<Word> wordRepository)
        {
            _wordRepository = wordRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Word>> Get()
        {
            return await _wordRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Word> Get(int id)
        {
            return await _wordRepository.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Word value)
        {
            await _wordRepository.AddAsync(value);
        }

        [HttpPut]
        public async Task Put([FromBody] Word value)
        {
            await _wordRepository.UpdateAsync(value);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Word value)
        {
            await _wordRepository.DeleteAsync(value);
        }
    }
}
