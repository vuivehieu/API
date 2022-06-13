using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class user_ingredient
    {
        [Key]
        public int ingredient_id { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string ingredient_name { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string quantity { get; set; }
        [Column(TypeName = "int(20)")]
       
        public string recipe_id { get; set; }
    }
}
