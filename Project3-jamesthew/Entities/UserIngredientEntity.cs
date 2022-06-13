using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class UserIngredientEntity
    {
        [Key]
        public int IngredientId { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string IngredientName { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Quantity { get; set; }
        [Column(TypeName = "int(20)")]
       
        public string RecipeId { get; set; }

        public UserIngredientEntity()
        {
            
        }

        public UserIngredientEntity(int ingredientId, string ingredientName, string quantity, string recipeId)
        {
            IngredientId = ingredientId;
            IngredientName = ingredientName;
            Quantity = quantity;
            RecipeId = recipeId;
        }
    }
}
