using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestMCompanyCoreAPI.Models;

namespace TestMCompanyCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MexpenseController : ControllerBase
    {
        private readonly DbBrokerageNewContext _context;
        public MexpenseController(DbBrokerageNewContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mexpense>>> GetData()
        {
            var data = await _context.Mexpenses.ToListAsync();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Mexpense>> GetById(int id)
        {
            var data = new Mexpense();
            data = await _context.Mexpenses.FirstOrDefaultAsync(m => m.ExpenseId == id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);

        }


        [HttpPost]
        public async Task<ActionResult<Mexpense>> SaveData(Mexpense model)
        {
            await _context.Mexpenses.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut]
        public async Task<ActionResult<Mexpense>> UpdateData(int id, Mexpense model)
        {
            if (id != model.ExpenseId)
            {
                return BadRequest();
            }
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete]
        public async Task<ActionResult<Mexpense>> DeleteData(int id)
        {
            var data = _context.Mexpenses.FirstOrDefaultAsync(m => m.ExpenseId == id);
            if (data == null)
            {
                return NotFound();
            }
            _context.Mexpenses.Remove(data);
            await _context.SaveChangesAsync();
            return ok();
        }



    }
}
