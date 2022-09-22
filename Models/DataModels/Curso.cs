using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace backendTest.Models.DataModels
{
    
    public enum LEVEL
    {
        Basic,
        Intermediate,
        Advanced
    }
    
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public LEVEL level { get; set; } = LEVEL.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
        
        public Chapters Chapters { get; set; } = new Chapters();

    }
}
