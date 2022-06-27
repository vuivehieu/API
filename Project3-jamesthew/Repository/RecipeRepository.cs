using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public RecipeRepository(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            this._context = context;
            _hostEnvironment = hostEnvironment;
        }
        public async Task<List<RecipesEntity>> GetAllRecipes()
        {
            return await _context.recipes.ToListAsync();
        }

        public async Task<RecipesEntity> GetRecipeById(int Id)
        {
            return await _context.recipes.FirstOrDefaultAsync(r => r.RecipesId == Id);
        }

        public async Task<RecipesEntity> AddRecipe(RecipesEntity recipe)
        {
            var result = await _context.recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteRecipe(int Id)
        {
            var result = await _context.recipes.SingleOrDefaultAsync(r => r.RecipesId == Id);
            if(result != null)
            {
                 _context.recipes.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<RecipesEntity> UpdateRecipe(RecipesEntity recipe)
        {
            var result = await _context.recipes
                .FirstOrDefaultAsync(r => r.RecipesId == recipe.RecipesId);
            if( result != null)
            {
                result.RecipesId = recipe.RecipesId;
                result.PrepationTime = recipe.PrepationTime;
                result.CookingTime = recipe.CookingTime;
                result.Serve = recipe.Serve;
                result.Calories = recipe.Calories;
                result.Difficulty = recipe.Difficulty;
                result.Proteins = recipe.Proteins;
                result.Carbs = recipe.Carbs;
                result.Fat = recipe.Fat;
                result.SaturatedFat = recipe.SaturatedFat;
                result.Fiber = recipe.Fiber;
                result.Sugar = recipe.Sugar;
                result.Salt = recipe.Salt;
                result.RecipesPic = recipe.RecipesPic;
                result.RecipesTitle = recipe.RecipesTitle;
                result.RecipesDescription = recipe.RecipesDescription;
                result.IsPaid = recipe.IsPaid;
                result.CategoriesId = recipe.CategoriesId;
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
