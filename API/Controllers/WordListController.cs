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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WordListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WordListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
