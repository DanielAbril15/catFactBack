
using BackendGodoy.Models;
using BackendGodoy.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendGodoy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactController : ControllerBase
    {
        private FactService _factService;
        public FactController(FactService factService) 
        {
            _factService = factService;
        }

        [HttpGet]
        public async Task<ActionResult<CatFact>> GetFact()=>
            await _factService.GetRandomFactAsync();

    }
}
