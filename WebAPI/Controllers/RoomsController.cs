using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        IRoomService _roomService;
        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _roomService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }




    }
}
