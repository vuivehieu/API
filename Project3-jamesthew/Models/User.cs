using Microsoft.AspNetCore.Identity;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } 
        /*public ICollection<UserRecipiesEntity> userRecipies { get; set; }*/
    }
}
