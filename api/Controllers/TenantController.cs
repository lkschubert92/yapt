using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yapt.Db;
using yapt.Models;

namespace yapt.Controllers
{
    [Route("api/[controller]")]
    public class TenantController : Controller
    {
        protected readonly DataContext Db;
        public TenantController(DataContext db)
        {
            Db = db;
        }

        [HttpGet("")]
        public IActionResult GetTenants()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTenant(int id)
        {
            var tenant = await Db.Tenants.FindAsync(new int[] { id });
            if (tenant == null)
                return NotFound();
            else
                return Ok(tenant);
        }

        [HttpPost("")]
        public async Task<IActionResult> PostTenant([FromBody]Tenant tenant)
        {
            if (!ModelState.IsValid)
                return BadRequest(new Error { Message = "Not a valid tenant object" });
            await Db.Tenants.AddAsync(tenant);
            await Db.SaveChangesAsync();
            return Ok(tenant);
        }

        [HttpPut("")]
        public async Task<IActionResult> PutTenant([FromBody]Tenant tenant)
        {
            if (!ModelState.IsValid)
                return BadRequest(new Error { Message = "Not a valid tenant object" });
            Db.Tenants.Attach(tenant);
            Db.Entry(tenant).State = EntityState.Modified;
            await Db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTenant(int id)
        {
            Db.Tenants.Remove(await Db.Tenants.FindAsync(new int[] { id }));
            return Ok();
        }
    }
}