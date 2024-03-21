using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestMCompanyCoreAPI.Models;

namespace TestMCompanyCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCompanyController : ControllerBase
    {
        private readonly DbBrokerageNewContext _context;

        public MCompanyController(DbBrokerageNewContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mcompany>>>Getdata()
        {
            var data = await _context.Mcompanies.ToListAsync();
            return Ok(data);
        }
    }
}
