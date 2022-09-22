using System.ComponentModel.DataAnnotations;

namespace backendTest.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public ICollection<Curso> Courses { get; set; } = new List<Curso>();

    }
}
