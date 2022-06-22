using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface IUserIngredientRepository
    {
        Task<List<UserIngredientEntity>> GetAllUserIgre();
        Task<UserIngredientEntity> GetUserIgreById(int Id);
        Task<UserIngredientEntity> AddUserIgre(UserIngredientEntity recipe);
        Task<UserIngredientEntity> UpdateUserIgre(UserIngredientEntity recipe);
        Task DeleteUserIgre(int Id);
    }
}
