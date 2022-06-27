using Project3_jamesthew.Entitites;
using Project3_jamesthew.Data;
using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly DataContext _context;
        public CategoriesRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<List<CategoryEntity>> GetAllCategory(string search)
        {
           #region Search
            var allCate =   _context.categories.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                allCate = allCate.Where(cate => cate.CategoryName.Contains(search));
            }
            #endregion

            return await allCate.ToListAsync();

     
        }

        public async Task<CategoryEntity> GetCategoryById(int Id)
        {
            return await _context.categories.FirstOrDefaultAsync(c => c.CategoryId == Id);
        }

        public async Task<CategoryEntity> AddCategory(CategoryModel cate)
        {
            cate.CategoryId = 0;
            var result = await _context.categories.AddAsync(CategoryModel.toEntity(cate));
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteCategory(int Id)
        {
            var result = await _context.categories.SingleOrDefaultAsync(c => c.CategoryId == Id);
            if(result != null)
            {
                _context.categories.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<CategoryEntity> UpdateCategory(CategoryModel cate)
        {
            var result = await _context.categories
                .FirstOrDefaultAsync(c => c.CategoryId == cate.CategoryId);
            if( result != null)
            {
                result.CategoryName = cate.CategoryName;
                result.CategoryDescription = cate.CategoryDescription;
                result.CategoryImg = cate.CategoryImg;
                result.CategoryIcon = cate.CategoryIcon;
                await _context.SaveChangesAsync();
                return result;
            }
            else
            {
                return null;
            }
        }

    }
}
