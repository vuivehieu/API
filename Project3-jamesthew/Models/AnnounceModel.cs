using System.ComponentModel.DataAnnotations;

namespace Project3_jamesthew.DataTransferObjects
{
    public class AnnounceModel
    {
        public int AnnounceId { get; set; }
        public DateTime AnnounceDate { get; set; }
        public string Email { get; set; }
        public int ContestId { get; set; }
        public int RecipeCompetitionId { get; set; }
        
    }
}
