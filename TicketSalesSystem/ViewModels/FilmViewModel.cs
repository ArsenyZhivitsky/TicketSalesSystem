using System.ComponentModel.DataAnnotations;

namespace TicketSalesSystem.ViewModels
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
