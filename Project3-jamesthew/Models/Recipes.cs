using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{

    public class Recipes
    {
        [Key]
        public int recipes_id { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string prepation_time { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string cooking_time { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string diffulty { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string serve { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string calories { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string carbs { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string fat { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string saluration { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string fiber { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string sugar { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string salt { get; set; }
        [Column(TypeName = "int(20)")]
        public int categories_id  { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipes_pic { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipes_title { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipes_description { get; set; }
        [Column(TypeName = "int(20)")]
      
        public int is_paid { get; set; } 
    }
}
