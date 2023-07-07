namespace WebApplicationCodeFirst.Models
{
    public class Student
    {
        public string City { get; set; }
        public string name { get; set; }
        public int pin { get; set; }
        public int Studid { get; set; }
        public DateOnly Date { get;set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string Email { get; set;} = string.Empty;

    }
}
