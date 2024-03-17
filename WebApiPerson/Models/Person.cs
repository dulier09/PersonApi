namespace WebApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string SecondName { get; set; }
        public required string LastName { get; set; }
        public string SecondLastName { get; set; }
        public required DateTime Birthdate { get; set; }
        public required double Salary { get; set; }
        public required DateTime CreationDate { get; set;}
        public required DateTime UpdateDate { get; set;}

    }
}
