namespace FootballAPI.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; internal set; }
        public int Money { get; internal set; }
    }
}
