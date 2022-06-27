using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class RecipesCompetitionRepository : IRecipesCompeRepository
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public RecipesCompetitionRepository(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            this._context = context;
            _hostEnvironment = hostEnvironment;
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
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }

        public void DeleteImage(string imageName)
        {
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
        }
    }
}
