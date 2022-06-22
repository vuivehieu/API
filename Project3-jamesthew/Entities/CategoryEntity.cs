using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class CategoryEntity
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string CategoryName { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string CategoryDescription { get; set; }
        [Column(TypeName = "varchar(300)")]
        [Required]
        public string CategoryIcon { get; set; }
        [Column(TypeName = "varchar(1000)")]
        [Required]
        public string CategoryImg { get; set; }
        

        public CategoryEntity(int categoryId, string categoryName, string categoryDescription, string categoryImg, string categoryIcon)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            CategoryImg = categoryImg;
            CategoryIcon = categoryIcon;
        }

        public CategoryEntity()
        {
            
        }
        public ICollection<RecipesEntity>? recipes { get; }
        public ICollection<ContestEntity>? contests { get; set; }
       

    }
}
