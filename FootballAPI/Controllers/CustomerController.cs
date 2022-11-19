using Microsoft.AspNetCore.Mvc;

namespace FootballAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet(Name = "GetAllCustomers")]

        public IEnumerable<Models.Person> GetAllCustomers([FromQuery] Models.Person person)
        {
            return Enumerable.Range(1, 5).Select(index => new Models.Person
            {
            })
            .ToArray();
        }
    }
}
