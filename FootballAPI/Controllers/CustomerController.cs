using FootballAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private ICustomerService _customerService;

        public CustomerController(ICustomerService customer)
        {
            _customerService = customer;
        }

        [HttpGet(Name = "BettingValidAge")]
        public string ValidAge([FromQuery] Person person) => _customerService.ValidAge(person);
    }
}
