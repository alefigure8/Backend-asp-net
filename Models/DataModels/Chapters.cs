using System.ComponentModel.DataAnnotations;
namespace backendTest.Models.DataModels
{
    public class Chapters : BaseEntity
    {
        public int CourseId { get; set; }
        public virtual Curso Curso { get; set; } = new Curso();
        
        [Required]
        public string List { get; set; } = string.Empty;
        
    }
}
