using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Feedback
    {
        [Key]
        public int fb_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string fb_name { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string email { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string review { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string phone_number { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string subject { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string details { get; set; }

    }
}
