using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Tips
    {
        [Key]
        public int tips_id { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string tips_img { get; set; }
        [Column(TypeName = "varchar(200)")]
        [Required]
        public string tips_description { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string tips_title { get; set; }

    }
}
