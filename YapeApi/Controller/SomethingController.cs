using Microsoft.AspNetCore.Mvc;
using YapeApi.Model;
using YapeApi.Repository;

namespace YapeApi.Controller
{
    [ApiController]
    public class SomethingController(ISomethingRepository somethingRepository) : ControllerBase
    {
        private readonly ISomethingRepository _somethingRepository = somethingRepository;

        [HttpPost("/something")]
        public async Task<IActionResult> AddSomething(Something something)
        {
            var createdSomething = await _somethingRepository.CreateSomethingAsync(something);
            return CreatedAtAction(nameof(AddSomething), createdSomething);
        }

        [HttpGet("/something")]
        public async Task<IActionResult> ListSomethings()
        {
            var somethings = await _somethingRepository.ListSomethingsAsync();
            return Ok(somethings);
        }

        [HttpGet("/something/{somethingId:int}")]
        public async Task<IActionResult> GetSomething(int somethingId)
        {
            var something = await _somethingRepository.GetSomethingAsync(somethingId);
            return something is null ? NotFound() : Ok(something);
        }

        [HttpPut("/something")]
        public async Task<IActionResult> UpdateSomething(Something something)
        {
            await _somethingRepository.UpdateSomethingAsync(something);
            return NoContent();
        }

        [HttpDelete("/something/{somethingId:int}")]
        public async Task<IActionResult> DeleteSomething(int somethingId)
        {
            await _somethingRepository.DeleteSomethingAsync(somethingId);
            return NoContent();
        }
    }
}