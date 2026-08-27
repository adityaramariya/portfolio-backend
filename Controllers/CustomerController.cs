using Microsoft.AspNetCore.Mvc;
using Portfolio.models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController: ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult setCustomerDetails(Customer Customer)
        {
            return Ok(new { CustomerInfo = Customer });
        }
    }

   
}



