using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface IIngredientRepository
    {
        Task<List<IngredientEntity>> GetAllIngredient();
        Task<IngredientEntity> GetIngredientById(int Id);
        Task<IngredientEntity> AddIngredient(IngredientEntity RecipesCompetition);
        Task<IngredientEntity> UpdateIngredient(IngredientEntity RecipesCompetition);
        Task DeleteIngredient(int Id);
    }
}
