using DbLabBackend.Models;
using DbLabBackend.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DbLabBackend.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IListRepo _listrepo;
        public ListController(IListRepo repo)
        {
            _listrepo = repo;
        }

        [HttpGet("getlist")]
        public async Task<IResult> GetList()
        {
            return await _listrepo.GetList();
        }

        [HttpGet("gethistory/{id}")]

        public async Task<IResult> GetHistory(int id)
        {
            return await _listrepo.GetHistory(id);
        }

        [HttpPost("additem")]
        public async Task<IResult> AddItem(AddItemDTO dto)
        {
            return await _listrepo.AddItem(dto);
        }

        [HttpPost("updateitem")]
        public async Task<IResult> UpdateItem(UpdateItemDTO dto)
        {
            return await _listrepo.UpdateItem(dto);
        }

        [HttpPost("removeitem/{id}")]
        public async Task<IResult> RemoveItem(int id)
        {
            return await _listrepo.RemoveItem(id);
        }

    }
}
