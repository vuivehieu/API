using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Repository
{
    public interface ICategoriesRepository
    {
        Task<List<CategoryEntity>> GetAllCategory(string search);
        Task<CategoryEntity> GetCategoryById(int Id);
        Task<CategoryEntity> AddCategory(CategoryModel cate);
        Task<CategoryEntity> UpdateCategory(CategoryModel cate);
        Task DeleteCategory(int Id);
    }
}
