using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using VBRESTAPI.Models;

namespace VBRESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        VBContext context;
        public CustomerController(VBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Customer> Get()
        {
            return context.Customer.ToList();
        }
    }
}
