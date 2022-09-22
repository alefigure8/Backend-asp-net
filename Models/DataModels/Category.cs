using System.ComponentModel.DataAnnotations;

namespace backendTest.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Curso> Courses { get; set; } = new List<Curso>();
    }
}
