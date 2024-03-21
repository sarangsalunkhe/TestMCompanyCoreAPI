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
            var data = _context.Mcustomers.ToListAsync();
            return Ok(data);
        }
    }
}
