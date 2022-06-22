using Project3_jamesthew.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class RecipesCompetitionEntity
    {
        [Key]
        public int RecipesCompetitionId { get; set; }
        [StringLength(20)]
        [Required]
        public int PrepationTime { get; set; }
        [StringLength(20)]
        [Required]
        public int CookingTime { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public EDifficulty Difficulty { get; set; }
        [StringLength(20)]
        [Required]
        public int Serve { get; set; }
        [StringLength(20)]
        [Required]
        public int Calories { get; set; }
        [StringLength(20)]
        [Required]
        public int Proteins { get; set; }
        [StringLength(20)]
        [Required]
        public int Carbs { get; set; }
        [StringLength(20)]
        [Required]
        public int Fat { get; set; }
        [StringLength(20)]
        [Required]
        public int SaturatedFat { get; set; }
        [StringLength(20)]
        [Required]
        public int Fiber { get; set; }
        [StringLength(20)]
        [Required]
        public int Sugar { get; set; }
        [StringLength(20)]
        [Required]
        public int Salt { get; set; }
        [StringLength(20)]
        [ForeignKey("Contest")]
        [Required]
        public int ContestId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string RecipesPic { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string RecipesTitle { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string RecipesDescription { get; set; }
 
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Winner { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string UserPic { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string UserDescription { get; set; }

        public RecipesCompetitionEntity(int recipesCompetitionId, int prepationTime, int cookingTime, EDifficulty difficulty, int serve, int calories, int proteins, int carbs, int fat, int saturatedFat, int fiber, int sugar, int salt, int contestId, string recipesPic, string recipesTitle, string recipesDescription, string userName, string userEmail, DateTime submitDate, string winner, string userPic, string userDescription)
        {
            RecipesCompetitionId = recipesCompetitionId;
            PrepationTime = prepationTime;
            CookingTime = cookingTime;
            Difficulty = difficulty;
            Serve = serve;
            Calories = calories;
            Proteins = proteins;
            Carbs = carbs;
            Fat = fat;
            SaturatedFat = saturatedFat;
            Fiber = fiber;
            Sugar = sugar;
            Salt = salt;
            ContestId = contestId;
            RecipesPic = recipesPic;
            RecipesTitle = recipesTitle;
            RecipesDescription = recipesDescription;
            UserName = userName;
            UserEmail = userEmail;
            SubmitDate = submitDate;
            Winner = winner;
            UserPic = userPic;
            UserDescription = userDescription;
           
        }
        public RecipesCompetitionEntity()
        {

        }

        public ContestEntity? Contest { get; set; }
/*        public ICollection<Announce> Announces { get; set; }
        public ICollection<IngredientCompetition> IngredientCompetitions { get; set; }
*/

    }
}
