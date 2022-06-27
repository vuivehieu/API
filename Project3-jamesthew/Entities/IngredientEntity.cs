using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
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
        [StringLength(20)]
        [ForeignKey("RecipesCompetitions")]
        [Required]
        public int RecipeCompetitionId { get; set; }
     

        public IngredientEntity(int ingredientId, string ingredientName, string quantity, int recipeCompetitionId)
        {
            IngredientId = ingredientId;
            IngredientName = ingredientName;
            Quantity = quantity;
            RecipeCompetitionId = recipeCompetitionId;
        }

        public IngredientEntity()
        {
            
        }
        public RecipesCompetitionEntity? RecipesCompetitions { get; set; }
    }
}
