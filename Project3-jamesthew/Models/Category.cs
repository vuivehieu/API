using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Category
    {
        [Key]
        public int category_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string cate_name { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string cate_description { get; set; }
        [Column(TypeName = "varchar(300)")]
        [Required]
        public string cate_img { get; set; }
        [Column(TypeName = "varchar(300)")]
        [Required]
        public string cate_icon { get; set; }

    }
}
