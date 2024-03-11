using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
