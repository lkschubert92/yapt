using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yapt.Db;
using yapt.Models;

namespace yapt.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
