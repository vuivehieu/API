using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class User_recipies
    {
        [Key]
        public string recipies_id { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string prepation_time { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string cooking_time { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string diffuty { get; set; }
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
        public string saturation { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string fiber { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string sugar { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string salt { get; set; }
        [Column(TypeName = "int(30)")]
        
        public int categories_id { get; set; }
        [Column(TypeName = "varchar(200)")]
        [Required]
        public string recipies_pic { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string recipe_title { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string recipe_description { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string user_name { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string user_email { get; set; }
        [Required]
        public DateTime submit_date { get; set; }
        [Column(TypeName = "int(30)")]       
        public int is_paid { get; set; }
        [Column(TypeName = "int(30)")]
        public int user_id { get; set; }

    }
}
