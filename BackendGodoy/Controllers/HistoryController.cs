using BackendGodoy.DTOs;
using BackendGodoy.Models;
using BackendGodoy.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendGodoy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly HistoryService _historyService;

        public HistoryController(HistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]
        public async Task<IEnumerable<History>> GetHistories()=>
            await _historyService.GetHistories();

        [HttpPost]
        public async Task<ActionResult<HistoryDto>> AddHistory(HistoryInsertDto historyDto)
        {
            var history = await _historyService.AddHistory(historyDto);

            return Created("Index", history);
        }
    }
}
