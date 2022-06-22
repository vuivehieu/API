using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class UserIngredientRepository : IUserIngredientRepository
    {
        private readonly DataContext _context;
        public UserIngredientRepository(DataContext context)
        {
            this._context = context;
        }
        public  Task<List<UserIngredientEntity>> GetAllUserIgre()
        {
            return  _context.usersIngredients.ToListAsync();
        }

        public async Task<UserIngredientEntity> GetUserIgreById(int Id)
        {
            return await _context.usersIngredients.FirstOrDefaultAsync(u => u.IngredientId == Id);
        }

        public async Task<UserIngredientEntity> AddUserIgre(UserIngredientEntity recipe)
        {
            var result = await _context.usersIngredients.AddAsync(recipe);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteUserIgre(int Id)
        {
            var result = await _context.usersIngredients.SingleOrDefaultAsync(u => u.IngredientId == Id);
            if(result != null)
            {
                 _context.usersIngredients.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<UserIngredientEntity> UpdateUserIgre(UserIngredientEntity ingredientEntity)
        {
            var result = await _context.usersIngredients
                .FirstOrDefaultAsync(u =>u.IngredientId == ingredientEntity.IngredientId);
            if(result != null)
            {
                result.IngredientId = ingredientEntity.IngredientId;
                result.IngredientName = ingredientEntity.IngredientName;
                result.Quantity = ingredientEntity.Quantity;
                result.RecipesId = ingredientEntity.RecipesId;
                await _context.SaveChangesAsync();
               
            }
            return null;
        }

 
    }
}
