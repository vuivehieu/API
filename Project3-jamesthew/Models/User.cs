using Microsoft.AspNetCore.Identity;

namespace Project3_jamesthew.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } 
    }
}
