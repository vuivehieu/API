using Project3_jamesthew.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.DataTransferObjects
{
    public class RecipesCompetitionDto
    {
        public int RecipesCompetitionId { get; set; }
        [Required]
        public int PrepationTime { get; set; }
        [Required]
        public int CookingTime { get; set; }
        [Required]
        public EDifficulty Difficulty { get; set; }
        [Required]
        public int Serve { get; set; }
        [Required]
        public int Calories { get; set; }
        [Required]
        public int Proteins { get; set; }
        [Required]
        public int Carbs { get; set; }
        [Required]
        public int Fat { get; set; }
        [Required]
        public int SaturatedFat { get; set; }
        [Required]
        public int Fiber { get; set; }
        [Required]
        public int Sugar { get; set; }
        [Required]
        public int Salt { get; set; }
        [Required]
        public int ContestId { get; set; }
        [Required]
        public string RecipesPic { get; set; }
        [Required]
        public string RecipesTitle { get; set; }
        [Required]
        public string RecipesDescription { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
        [Required]
        public string Winner { get; set; }
        [Required]
        public string UserPic { get; set; }
        [Required]
        public string UserDescription { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }
    }
}
