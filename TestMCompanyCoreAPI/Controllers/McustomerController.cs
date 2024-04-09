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

        [HttpPost]
        public async Task<ActionResult<Mcustomer>>SaveData(Mcustomer model)
        {
            await _context.Mcustomers.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut]
        public async Task<ActionResult<Mcustomer>>UpdateData(int id,Mcustomer model)
        {
            if(id!=model.CustomerId)
            {
                return BadRequest();
            }
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete]
        public async Task<ActionResult<Mcompany>>DeleteData(int id)
        {
            var data = await _context.Mcompanies.FirstOrDefaultAsync(m => m.CompanyId == id);
            if(data==null)
            {
                return NotFound();
            }
            _context.Mcompanies.Remove(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
