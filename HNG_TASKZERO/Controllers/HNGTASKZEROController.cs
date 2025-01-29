using HNG_TASKZERO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG_TASKZERO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HNGTASKZEROController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetResponse()
        {
            var response = new ResponseModel
            {
                email = "brightelo1@gmail.com",
                current_Datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/OBE96/HNG_TASK_0"
            };
            return Ok(response);
        }
    }
}
