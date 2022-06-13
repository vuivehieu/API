using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Ingredient
    {
        [Key]
        public int ingredient_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ingredient_name { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string quantity { get; set; }
        [Column(TypeName = "int(50)")]
        public int recipies_id { get; set; }

    }
}
