using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Models
{
    public class Announce
    {
        [Key]
        public int announce_id { get; set; }
        [Required]
        public DateTime announce_date { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string email { get; set; }
        [Column(TypeName = "int(30)")]
        public int contest_id { get; set; }
        [Column(TypeName = "int(30)")]
        public int recipe_competion_id { get; set; }

    }
}
