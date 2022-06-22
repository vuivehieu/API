using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class RecipesCompetitionRepository : IRecipesCompeRepository
    {
        private readonly DataContext _context;
        public RecipesCompetitionRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<List<RecipesCompetitionEntity>> GetAllRecipesCompe()
        {
            return await _context.recipesCompetitions.ToListAsync();
        }

        public async Task<RecipesCompetitionEntity> GetRecipesCompeById(int Id)
        {
            return await _context.recipesCompetitions.FirstOrDefaultAsync(r => r.RecipesCompetitionId == Id);
        }

        public async Task<RecipesCompetitionEntity> AddRecipesCompe(RecipesCompetitionEntity RecipesCompetition)
        {
            var result = await _context.recipesCompetitions.AddAsync(RecipesCompetition);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteRecipesCompetition(int Id)
        {
            var result = await _context.recipesCompetitions.SingleOrDefaultAsync(r => r.RecipesCompetitionId == Id);
            if(result != null)
            {
                 _context.recipesCompetitions.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<RecipesCompetitionEntity> UpdateRecipesCompe(RecipesCompetitionEntity RecipesCompetition)
        {
            var result =await _context.recipesCompetitions
                .FirstOrDefaultAsync(r => r.RecipesCompetitionId == RecipesCompetition.RecipesCompetitionId);
            if(result != null)
            {
                result.RecipesCompetitionId = RecipesCompetition.RecipesCompetitionId;
                result.PrepationTime = RecipesCompetition.PrepationTime;
                result.CookingTime = RecipesCompetition.CookingTime;
                result.Difficulty = RecipesCompetition.Difficulty;
                result.Serve = RecipesCompetition.Serve;
                result.Calories = RecipesCompetition.Calories;
                result.Proteins = RecipesCompetition.Proteins;
                result.Carbs = RecipesCompetition.Carbs;
                result.Fat = RecipesCompetition.Fat;
                result.SaturatedFat = RecipesCompetition.SaturatedFat;
                result.Fiber = RecipesCompetition.Fiber;
                result.Sugar = RecipesCompetition.Sugar;
                result.Salt = RecipesCompetition.Salt;
                result.ContestId = RecipesCompetition.ContestId;
                result.RecipesPic = RecipesCompetition.RecipesPic;
                result.RecipesTitle = RecipesCompetition.RecipesTitle;
                result.RecipesDescription = RecipesCompetition.RecipesDescription;
                result.UserName = RecipesCompetition.UserName;
                result.UserEmail = RecipesCompetition.UserEmail;
                result.SubmitDate = RecipesCompetition.SubmitDate;
                result.Winner = RecipesCompetition.Winner;
                result.UserPic = RecipesCompetition.UserPic;
                result.UserDescription = RecipesCompetition.UserDescription;
                await _context.SaveChangesAsync();
            }
            return null;

        }
    }
}
