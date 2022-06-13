using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class IngredientEntity
    {
        [Key]
        public int IngredientId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string IngredientName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Quantity { get; set; }
        [Column(TypeName = "int(50)")]

        public RecipesEntity Recipes { get; set; }


        public IngredientEntity(int ingredientId, string ingredientName, string quantity, RecipesEntity recipes)
        {
            IngredientId = ingredientId;
            IngredientName = ingredientName;
            Quantity = quantity;
            Recipes = recipes;
        }

        public IngredientEntity()
        {
            
        }
    }
}
