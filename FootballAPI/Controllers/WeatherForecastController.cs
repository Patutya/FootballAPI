using Microsoft.AspNetCore.Mvc;

namespace FootballAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /*
        [HttpGet(Name = "GetAllCustomers")]
        public IEnumerable<Models.Person> GetAllCustomers([FromQuery]Models.Person person)
        {
            return Enumerable.Range(1, 5).Select(index => new Models.Person
            {
               /* Name = name,
                Age = age,
                Surname = name + "shvili0",
                Money = age * age
            })
            .ToArray();
        }*/
    }
}