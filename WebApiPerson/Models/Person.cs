using System.ComponentModel.DataAnnotations;

namespace WebApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string SecondLastName { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "El salario es obligatorio")]
        public double Salary { get; set; }
        public DateTime CreationDate { get; set;}
        public DateTime UpdateDate { get; set;}

    }
}
