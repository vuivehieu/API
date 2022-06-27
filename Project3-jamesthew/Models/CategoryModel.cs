using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Models;

public class CategoryModel
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public string CategoryIcon { get; set; }
    public string CategoryImg { get; set; }
    public IFormFile ImageFile { get; set; }
    public string ImageSrc { get; set; }

    public static CategoryEntity toEntity(CategoryModel model)
    {
        return new CategoryEntity()
        {
            CategoryId = model.CategoryId,
            CategoryDescription = model.CategoryDescription,
            CategoryIcon = model.CategoryIcon,
            CategoryName = model.CategoryName,
            CategoryImg = model.CategoryImg
        };
    }
}