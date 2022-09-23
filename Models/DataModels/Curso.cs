using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace backendTest.Models.DataModels
{
    
    public enum LEVELS
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
        public string Description { get; set; } = string.Empty;

        [Required, StringLength(1000)]
        public string FullDescription { get; set; } = string.Empty;
        
        [Required, StringLength(1000)]
        public string PublicTarget { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string Targets { get; set; } = string.Empty;


        [Required, StringLength(280)]
        public string Requiered { get; set; } = string.Empty;

        [Required]
        public LEVELS Level { get; set; } = LEVELS.Basic;
    }
}
