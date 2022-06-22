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
        public int ContestId { get; set; }
        [Required]
        [Column(TypeName = "int(10)")]
        public int RecipeCompetitionId { get; set; }

        public AnnounceEntity()
        {
            
        }

        public AnnounceEntity(DateTime announceDate, int contestId, int recipeCompetitionId, string email)
        {
            this.AnnounceDate = announceDate;
            this.ContestId = contestId;
            this.RecipeCompetitionId = recipeCompetitionId;
            this.Email = email;
        }
        public ContestEntity Contest { get; set; }
       /* public virtual RecipesCompetition RecipesCompetition { get; set; }*/
    }
}
