using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class ContestEntity
    {
        [Key]
        public int ContestId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ContestTitle { get; set; }
        [Required]
        public DateTime ContestStart { get; set; }
        [Required]
        public DateTime ContestEnd { get; set; }
        [StringLength(20)]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public bool IsOpen { get; set; }
        [Column(TypeName = "varchar(1000)")]
        [Required]
        public string ContestDescription { get; set; }

        public ContestEntity(int contestId, string contestTitle, DateTime contestStart, DateTime contestEnd, int categoryId, bool isOpen, string contestDescription)
        {
            ContestId = contestId;
            ContestTitle = contestTitle;
            ContestStart = contestStart;
            ContestEnd = contestEnd;
            CategoryId = categoryId;
            IsOpen = isOpen;
            ContestDescription = contestDescription;
        }

        public ContestEntity()
        {
            
        }
       
    /*    public ICollection<Announce> Announces { get; set; }*/
        public CategoryEntity? Category { get; set; }
        public ICollection<RecipesCompetitionEntity> RecipesCompetitions { get; set; }

    }
}
