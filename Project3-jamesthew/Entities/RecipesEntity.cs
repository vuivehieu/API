/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{

    public class RecipesEntity
    {
        [Key]
        public int RecipesId { get; set; }

        [Column(TypeName = "int(20)")]
        [Required]
        public int PrepationTime { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int CookingTime { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public EDifficulty Difficulty { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Serve { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Calories { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Proteins { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Carbs { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Fat { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int SaturatedFat { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Fiber { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Sugar { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int Salt { get; set; }
        [Column(TypeName = "int(20)")]
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
        [Column(TypeName = "byte")]
        public bool IsPaid { get; set; }

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
        public virtual CategoryEntity Category { get; set; }
        public ICollection<IngredientEntity> Ingredients { get; set; }
        public ICollection<UserIngredientEntity> UserIngredients { get; set; }
    }
}
*/