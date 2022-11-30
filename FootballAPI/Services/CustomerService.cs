using FootballAPI.Models;

namespace FootballAPI.Services
{
    public class CustomerService : ICustomerService
    {
        public string ValidAge(Person person)
        {

            {
                if (person.Age > 17)
                {
                    person.valid = true;
                    return "Dashvebulia";
                }
                else
                {
                    person.valid = false;
                    return "DAUSHVEBELIA asakis gamo (+18)";
                }
            }
        }
    }
}
