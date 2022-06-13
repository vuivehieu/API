using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class FaqEntity
    {
        [Key]
        public int FaqId { get; set; }
        [Column(TypeName = "varchar(1500)")]
        [Required]
        public string FaqQuestion { get; set; }
        [Column(TypeName = "varchar(1500)")]
        [Required]
        public string FaqAns { get; set; }

        public FaqEntity(int faqId, string faqQuestion, string faqAns)
        {
            FaqId = faqId;
            FaqQuestion = faqQuestion;
            FaqAns = faqAns;
        }

        public FaqEntity()
        {
            
        }
    }
}
