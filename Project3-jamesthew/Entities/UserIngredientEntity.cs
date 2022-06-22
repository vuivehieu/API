using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
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
        [StringLength(20)]
        [ForeignKey("Recipes")]
        public int RecipesId { get; set; }

        public UserIngredientEntity()
        {
            
        }

        public UserIngredientEntity(int ingredientId, string ingredientName, string quantity, int recipesId)
        {
            IngredientId = ingredientId;
            IngredientName = ingredientName;
            Quantity = quantity;
            RecipesId = recipesId;
        }
        public  RecipesEntity? Recipes { get; set; }
    }
}
