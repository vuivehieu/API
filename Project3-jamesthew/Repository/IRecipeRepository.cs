using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface IRecipeRepository
    {
        Task<List<RecipesEntity>> GetAllRecipes();
        Task<RecipesEntity> GetRecipeById(int Id);
        Task<RecipesEntity> AddRecipe(RecipesEntity recipe);
        Task<RecipesEntity> UpdateRecipe(RecipesEntity recipe);
        Task DeleteRecipe(int Id);
    }
}
