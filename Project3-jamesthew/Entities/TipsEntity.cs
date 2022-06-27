using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class TipsEntity
    {
        [Key]
        public int TipsId { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string TipsTitle { get; set; }
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string TipsDescription { get; set; }
     
        [Column(TypeName = "varchar(1500)")]
        [Required]
        public string TipsImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


        [NotMapped]
        public string ImageSrc { get; set; }
        public TipsEntity(int tipsId, string tipsImage, string tipsDescription, string tipsTitle)
        {
            TipsId = tipsId;
            TipsImage = tipsImage;
            TipsDescription = tipsDescription;
            TipsTitle = tipsTitle;
        }

        public TipsEntity()
        {
            
        }
    }
}
