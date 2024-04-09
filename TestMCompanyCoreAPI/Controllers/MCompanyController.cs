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

        [HttpGet("{id}")]
        public async Task<ActionResult<Mcompany>> GetDataById(int id)
        {
            var data=new Mcompany();
            data = await _context.Mcompanies.FirstOrDefaultAsync(m=>m.CompanyId==id);
           if(data==null)
            {
                return NotFound();
            }
            return data;
        }

        [HttpPost]
        public async Task<ActionResult<Mcompany>>SaveData(Mcompany model)
        {
            await _context.Mcompanies.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut]
        public async Task<ActionResult<Mcompany>>UpdateData(int id,Mcompany model)
        {
            if(id!=model.CompanyId)
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
            var data = await _context.Mcompanies.FirstOrDefaultAsync(m => m.CompanyId == id); ;    
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
