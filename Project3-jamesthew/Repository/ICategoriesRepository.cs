using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface ICategoriesRepository
    {
        Task<List<CategoryEntity>> GetAllCategory(string search);
        Task<CategoryEntity> GetCategoryById(int Id);
        Task<CategoryEntity> AddCategory(CategoryEntity cate);
        Task<CategoryEntity> UpdateCategory(CategoryEntity cate);
        Task DeleteCategory(int Id);
    }
}
