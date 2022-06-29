using Project3_jamesthew.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class UserRecipiesEntity:RecipesEntity
    {
        [Required]
        public DateTime SubmitDate { get; set; }

        [StringLength(20)]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [StringLength(20)]
        [ForeignKey("user")]
        public int UserId { get; set; }
        
        public UserRecipiesEntity()
        {
            
        }

        public UserRecipiesEntity(DateTime submitDate, int userId, int recipesId, int prepationTime, int cookingTime, EDifficulty difficulty, int serve, int calories, int proteins, int carbs, int fat, int saturatedFat, int fiber, int sugar, int salt, int categoriesId, string recipesPic, string recipesTitle, string recipesDescription, bool isPaid) 
            : base(recipesId, prepationTime, cookingTime, difficulty, serve, calories, proteins, carbs, fat, saturatedFat, fiber, sugar, salt, categoriesId, recipesPic, recipesTitle, recipesDescription, isPaid) 
        {
            SubmitDate = submitDate;
            UserId = userId;
        }
        public virtual CategoryEntity Category { get; set; }
        public UserEntity user { get; set; }
    }
}
