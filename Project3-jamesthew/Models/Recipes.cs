using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{

    public class Recipes
    {
        [Key]
        public int recipesId { get; set; }

        [Column(TypeName = "int(20)")]
        [Required]
        public int prepationTime { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int cookingTime { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public EDifficulty difficulty { get; set }
        [Column(TypeName = "int(20)")]
        [Required]
        public int serve { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int calories { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int proteins { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int carbs { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int fat { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int saturatedFat { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int fiber { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int sugar { get; set; }
        [Column(TypeName = "int(20)")]
        [Required]
        public int salt { get; set; }
        [Column(TypeName = "int(20)")]
        public int categoriesId  { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipesPic { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipesTitle { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipesDescription { get; set; }
        [Column(TypeName = "byte")]
        public bool isPaid { get; set; } 
    }
}
