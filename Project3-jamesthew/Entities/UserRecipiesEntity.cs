using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class UserRecipiesEntity:RecipesEntity
    {
        public string UserName { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
        [Column(TypeName = "int(30)")]       
        public int IsPaid { get; set; }
        [Column(TypeName = "int(30)")]
        public int UserId { get; set; }

        public UserRecipiesEntity()
        {
            
        }

        public UserRecipiesEntity(string userName, string userEmail, DateTime submitDate, int isPaid, int userId)
        {
            UserName = userName;
            UserEmail = userEmail;
            SubmitDate = submitDate;
            IsPaid = isPaid;
            UserId = userId;
        }
    }
}
