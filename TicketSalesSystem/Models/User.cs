using Microsoft.AspNetCore.Identity;

namespace TicketSalesSystem.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
