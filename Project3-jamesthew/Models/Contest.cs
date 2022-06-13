using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Contest
    {
        [Key]
        public int contest_id { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string contest_title { get; set; }
        [Required]
        public DateTime contest_start { get; set; }
        [Required]
        public DateTime contest_end { get; set; }
        [Column(TypeName = "int(30)")]
        public int category_id { get; set; }
        [Column(TypeName = "int(30)")]
        public int is_open { get; set; }
        [Column(TypeName = "varchar(400)")]
        [Required]
        public string contest_description { get; set; }

    }
}
