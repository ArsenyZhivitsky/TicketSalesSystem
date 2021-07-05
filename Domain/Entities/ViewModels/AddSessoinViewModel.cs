using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.ViewModels
{
    public class AddSessoinViewModel
    {
        [Required]
        [Display(Name = "Select a cinema")]
        public int CinemaId { get; set; }

        [Required]
        [Display(Name = "Select a date")]
        [DataType(DataType.DateTime)]
        public string Description { get; set; }
    }
}
