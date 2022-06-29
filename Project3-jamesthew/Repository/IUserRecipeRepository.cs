using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Repository;

public interface IUserRecipeRepository
{
    Task<IEnumerable<UserRecipiesEntity>> getAllUserRecipiesByUid(string uid);

    Task<Task<List<UserRecipiesEntity>>> getAllUserRecipies();

    Task<UserRecipiesEntity> getUserRecipiesByUidAndId(string uid, long id);

    Task<UserRecipiesEntity> getUserRecipiesById(long id);

    Task<UserRecipiesEntity> addUserRecipies(UserRecipiesModel model);

    Task<UserRecipiesEntity> updateUserRecipies(UserRecipiesModel model);

    Task<bool> deleteUserRecipies(int id);
}