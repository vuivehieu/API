using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly DataContext _context;
        public IngredientRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<IngredientEntity>> GetAllIngredient()
        {
            return await _context.ingredients.ToListAsync();
        }

        public async Task<IngredientEntity> GetIngredientById(int Id)
        {
            return await _context.ingredients.FirstOrDefaultAsync(i => i.IngredientId == Id);
        }

        public async Task<IngredientEntity> AddIngredient(IngredientEntity RecipesCompetition)
        {
            var result = await _context.ingredients.AddAsync(RecipesCompetition);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteIngredient(int Id)
        {
            var result = await _context.ingredients.SingleOrDefaultAsync(i => i.IngredientId == Id);
            if(result != null)
            {
                _context.ingredients.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IngredientEntity> UpdateIngredient(IngredientEntity RecipesCompetition)
        {
            var result = await _context.ingredients.FirstOrDefaultAsync(i => i.IngredientId == RecipesCompetition.IngredientId);
            if(result != null)
            {
                result.IngredientId = RecipesCompetition.IngredientId;
                result.IngredientName = RecipesCompetition.IngredientName;
                result.Quantity = RecipesCompetition.Quantity;
                result.RecipeCompetitionId = RecipesCompetition.RecipeCompetitionId;
                await _context.SaveChangesAsync();
            }
            return null;
        }
    }
}
