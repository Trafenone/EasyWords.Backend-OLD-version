using Application.Common.Interfaces.Base;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IEnumerable<Word>> Get(CancellationToken cancellationToken)
        {
            return await _wordRepository.GetAllAsync(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<Word> Get(int id, CancellationToken cancellationToken)
        {
            return await _wordRepository.GetByIdAsync(id, cancellationToken);
        }

        [HttpPost]
        public async Task Post([FromBody] Word value, CancellationToken cancellationToken)
        {
            await _wordRepository.AddAsync(value, cancellationToken);
        }

        [HttpPut]
        public async Task Put([FromBody] Word value, CancellationToken cancellationToken)
        {
            await _wordRepository.UpdateAsync(value, cancellationToken);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            await _wordRepository.DeleteAsync(id, cancellationToken);
        }
    }
}
