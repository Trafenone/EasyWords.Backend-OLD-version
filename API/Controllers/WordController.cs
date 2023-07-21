using Application.Words.Commands.CreateWord;
using Application.Words.Commands.DeleteWord;
using Application.Words.Commands.UpdateWord;
using Application.Words.Queries.GetAllWordsById;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ApiBaseController
    {

        [HttpGet("{id}")]
        public async Task<ActionResult<WordVm>> Get(Guid id)
        {
            return Ok(await Mediator.Send(new GetWordsQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateWordCommand value)
        {
            await Mediator.Send(value);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateWordCommand value)
        {
            await Mediator.Send(value);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteWordCommand { Id = id }));
        }
    }
}
