/*using Project3_jamesthew.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class UserRecipiesEntity:RecipesEntity
    {
        public string UserName { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
      
        [StringLength(20)]
        public int UserId { get; set; }

        public UserRecipiesEntity()
        {
            
        }

        public UserRecipiesEntity(string userName, string userEmail, DateTime submitDate, int userId, int recipesId, int prepationTime, int cookingTime, EDifficulty difficulty, int serve, int calories, int proteins, int carbs, int fat, int saturatedFat, int fiber, int sugar, int salt, int categoriesId, string recipesPic, string recipesTitle, string recipesDescription, bool isPaid) 
            : base(recipesId, prepationTime, cookingTime, difficulty, serve, calories, proteins, carbs, fat, saturatedFat, fiber, sugar, salt, categoriesId, recipesPic, recipesTitle, recipesDescription, isPaid) 
        {
            UserName = userName;
            UserEmail = userEmail;
            SubmitDate = submitDate;
            UserId = userId;
        }
        public virtual CategoryEntity Category { get; set; }
        public User user { get; set; }
    }
}
*/