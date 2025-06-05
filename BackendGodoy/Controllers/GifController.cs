using BackendGodoy.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendGodoy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GifController : ControllerBase
    {
        private readonly GifService _gifService;

        public GifController(GifService gifService)
        {
            _gifService = gifService;
        }

        [HttpGet]
        public async Task<IActionResult> getGif([FromQuery] string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return BadRequest("Query debe tener valor");
            }
            else
            {
                var gif = await _gifService.GetGif(query);
                return Ok(gif);
            }
        }
    }
}
