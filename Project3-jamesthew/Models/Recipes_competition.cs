using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Recipes_competition
    {
        [Key]
        public int recipes_competition_id { get; set; }
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
        public string proteins { get; set; }
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
        [Column(TypeName = "int(30)")]
     
        public int contest_id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string repices_pic { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string repices_title { get; set; }
        [Column(TypeName = "varchar(200)")]
        [Required]
        public string recipes_description { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string user_name { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string user_email { get; set; }
        
        [Required]
        public DateTime submit_date { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string winner { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string user_pic { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string user_description { get; set; }

    }
}
