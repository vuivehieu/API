using System.ComponentModel.DataAnnotations;

namespace Project3_jamesthew.DataTransferObjects
{
    public class IngredientDto
    {
        public int IngredientId { get; set; }
        [Required]
        public string IngredientName { get; set; }
      
        [Required]
        public string Quantity { get; set; }
        [Required]
        public int RecipeCompetitionId { get; set; }
    }
}
