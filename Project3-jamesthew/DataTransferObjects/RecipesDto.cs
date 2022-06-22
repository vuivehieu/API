using Project3_jamesthew.Entitites;
using Project3_jamesthew.DataTransferObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.DataTransferObjects
{
    public class RecipesDto
    {
        public int RecipesId { get; set; }

        [Required]
        public int PrepationTime { get; set; }

        [Required]
        public int CookingTime { get; set; }



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

        public int SaturatedFat { get; set; }

        public int Fiber { get; set; }

        public int Sugar { get; set; }

        public int Salt { get; set; }

        public int CategoriesId { get; set; }
        [Required]
        public string RecipesPic { get; set; }
        [Required]
        public string RecipesTitle { get; set; }

        [Required]
        public string RecipesDescription { get; set; }

        public bool IsPaid { get; set; }

       /* public CategoryEntity? Category { get;  }*/

    }
}
