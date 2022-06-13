using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class FaQ
    {
        [Key]
        public int faq_id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string faq_question { get; set; }
        [Column(TypeName = "varchar(200)")]
        [Required]
        public string faq_ans { get; set; } 
    }
}
