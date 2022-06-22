using System.ComponentModel.DataAnnotations;

namespace Project3_jamesthew.DataTransferObjects
{
    public class ContestDto
    {
        public int ContestId { get; set; }
        [Required]
        public string ContestTitle { get; set; }
        [Required]
        public DateTime ContestStart { get; set; }
        [Required]
        public DateTime ContestEnd { get; set; }    
        public int CategoryId { get; set; }
        public bool IsOpen { get; set; }

        [Required]
        public string ContestDescription { get; set; }
    }
}
