using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Contact
    {
        [Key]
        public int contact_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string user_name { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string user_email { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string user_number { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string user_message { get; set; }

    }
}
