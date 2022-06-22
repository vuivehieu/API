using System.ComponentModel.DataAnnotations;

namespace Project3_jamesthew.DataTransferObjects
{
    public class UserIgredientDto
    {
        public int IngredientId { get; set; }
       
        [Required]
        public string IngredientName { get; set; }
    
        [Required]
        public string Quantity { get; set; }
        
        public int RecipesId { get; set; }
    }
}
