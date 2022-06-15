/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class ContactEntity
    {
        [Key]
        public int ContactId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Username { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string UserEmail { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string UserNumber { get; set; }
        [Column(TypeName = "varchar(1500)")]
        [Required]
        public string UserMessage { get; set; }

        public ContactEntity(int contactId, string username, string userEmail, string userNumber, string userMessage)
        {
            ContactId = contactId;
            Username = username;
            UserEmail = userEmail;
            UserNumber = userNumber;
            UserMessage = userMessage;
        }
    }
}
*/