using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface IRecipesCompeRepository
    {
        Task<List<RecipesCompetitionEntity>> GetAllRecipesCompe();
        Task<RecipesCompetitionEntity> GetRecipesCompeById(int Id);
        Task<RecipesCompetitionEntity> AddRecipesCompe(RecipesCompetitionEntity RecipesCompetition);
        Task<RecipesCompetitionEntity> UpdateRecipesCompe(RecipesCompetitionEntity RecipesCompetition);
        Task DeleteRecipesCompetition(int Id);
        Task<string> SaveImage(IFormFile imageFile);
        void DeleteImage(string imageName);
    }
}
