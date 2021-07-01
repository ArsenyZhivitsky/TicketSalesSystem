using System.ComponentModel.DataAnnotations;

namespace TicketSalesSystem.ViewModels
{
    public class CinemaViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
