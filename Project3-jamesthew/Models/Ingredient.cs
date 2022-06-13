using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Ingredient
    {
        [Key]
        public int ingredientId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ingredientName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string quantity { get; set; }
        [Column(TypeName = "int(50)")]

        public Recipes Recipes { get; set; }

    }
}
