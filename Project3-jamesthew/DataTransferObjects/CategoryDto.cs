using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Controllers;

public class CategoryDto
{
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public string CategoryIcon { get; set; }
    public string CategoryImg { get; set; }

    public static CategoryDto toDto(CategoryEntity entity)
    {
        return new CategoryDto()
        {
            CategoryDescription = entity.CategoryDescription,
            CategoryIcon = entity.CategoryIcon,
            CategoryImg = entity.CategoryImg,
            CategoryName = entity.CategoryName
        };
    }
}