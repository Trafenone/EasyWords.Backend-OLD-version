using Application.WordLists.Commands.CreateWordList;
using Application.WordLists.Commands.DeleteWordList;
using Application.WordLists.Commands.UpdateWordList;
using Application.WordLists.Queries.GetAllWordList;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordListController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult<WordListVm>> Get()
        {
            return Ok(await Mediator.Send(new GetWordListQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateWordListCommand value)
        {
            await Mediator.Send(value);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateWordListCommand  value)
        {
            await Mediator.Send(value);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteWordListCommand { Id = id });

            return Ok();
        }
    }
}
