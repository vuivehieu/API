using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    
    public class AnnounceEntity
    {
        [Key]
        public int AnnounceId { get; set; }
        [Required]
        public DateTime AnnounceDate { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        [ForeignKey("Contest")]
        public int ContestId { get; set; }
       
        public ContestEntity? Contest { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey("RecipeCompetition")]
        public int RecipeCompetitionId { get; set; }

        public RecipesCompetitionEntity? RecipeCompetition { get; set; }
        public AnnounceEntity()
        {
            
        }

        public AnnounceEntity(int announceId, DateTime announceDate, int contestId, int recipeCompetitionId, string email)
        {
            AnnounceId = announceId;
            AnnounceDate = announceDate;
            ContestId = contestId;
            RecipeCompetitionId = recipeCompetitionId;
            Email = email;
        }
       
        
    }
}
