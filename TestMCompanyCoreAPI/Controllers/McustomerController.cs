using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestMCompanyCoreAPI.Models;

namespace TestMCompanyCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class McustomerController : ControllerBase
    {
        private readonly DbBrokerageNewContext _context;
        public McustomerController(DbBrokerageNewContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mcustomer>>>GetData()
        {
            var data =await _context.Mcustomers.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mcustomer>>GetDataById(int id)
        {
            var data = new Mcustomer();
            data = await _context.Mcustomers.FirstOrDefaultAsync(x => x.CustomerId == id);
            await _context.SaveChangesAsync();
            if(data==null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
