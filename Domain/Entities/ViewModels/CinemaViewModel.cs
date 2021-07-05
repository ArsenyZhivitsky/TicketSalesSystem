using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.ViewModels
{
    public class CinemaViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
