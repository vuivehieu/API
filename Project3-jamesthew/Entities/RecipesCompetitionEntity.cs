using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class RecipesCompetitionEntity:RecipesEntity
    {
        [Key]
        public int RecipesCompetitionId { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public int ContestId { get; set; }
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

        public RecipesCompetitionEntity(int recipesId, int prepationTime, int cookingTime, EDifficulty difficulty, int serve, int calories, int proteins, int carbs, int fat, int saturatedFat, int fiber, int sugar, int salt, int categoriesId, string recipesPic, string recipesTitle, string recipesDescription, bool isPaid, int recipesCompetitionId, int contestId, string userName, string userEmail, DateTime submitDate, string winner, string userPic, string userDescription) : base(recipesId, prepationTime, cookingTime, difficulty, serve, calories, proteins, carbs, fat, saturatedFat, fiber, sugar, salt, categoriesId, recipesPic, recipesTitle, recipesDescription, isPaid)
        {
            RecipesCompetitionId = recipesCompetitionId;
            ContestId = contestId;
            UserName = userName;
            UserEmail = userEmail;
            SubmitDate = submitDate;
            Winner = winner;
            UserPic = userPic;
            UserDescription = userDescription;
        }

        public RecipesCompetitionEntity(int recipesCompetitionId, int contestId, string userName, string userEmail, DateTime submitDate, string winner, string userPic, string userDescription)
        {
            RecipesCompetitionId = recipesCompetitionId;
            ContestId = contestId;
            UserName = userName;
            UserEmail = userEmail;
            SubmitDate = submitDate;
            Winner = winner;
            UserPic = userPic;
            UserDescription = userDescription;
        }


    }
}
