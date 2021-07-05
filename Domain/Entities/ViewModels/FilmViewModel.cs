using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.ViewModels
{
    public class FilmViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
