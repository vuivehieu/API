using Project3_jamesthew.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{

    public class RecipesEntity
    {
        [Key]
        public int RecipesId { get; set; }

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
        [ForeignKey("Category")]
        public int CategoriesId  { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string RecipesPic { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string RecipesTitle { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string RecipesDescription { get; set; }
        
        public bool IsPaid { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }
        public RecipesEntity(int recipesId, int prepationTime, int cookingTime, EDifficulty difficulty, int serve, int calories, int proteins, int carbs, int fat, int saturatedFat, int fiber, int sugar, int salt, int categoriesId, string recipesPic, string recipesTitle, string recipesDescription, bool isPaid)
        {
            RecipesId = recipesId;
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
            CategoriesId = categoriesId;
            RecipesPic = recipesPic;
            RecipesTitle = recipesTitle;
            RecipesDescription = recipesDescription;
            IsPaid = isPaid;
        }

        public RecipesEntity()
        {
            
        }
        public CategoryEntity? Category { get; set; }
        public ICollection<UserIngredientEntity>? UserIngredients { get; set; }

    }
}
