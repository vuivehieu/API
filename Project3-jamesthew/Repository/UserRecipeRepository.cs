using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Repository;

public class UserRecipeRepository : IUserRecipeRepository
{
    private readonly DataContext _dataContext;

    public UserRecipeRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<IEnumerable<UserRecipiesEntity>> getAllUserRecipiesByUid(string uid)
    {
        return _dataContext.UserRecipies.;
    }

    public async Task<Task<List<UserRecipiesEntity>>> getAllUserRecipies()
    {
        return _dataContext.UserRecipies.ToListAsync();
    }

    public async Task<UserRecipiesEntity> getUserRecipiesByUidAndId(string uid, long id)
    {
        return await _dataContext.UserRecipies.Include(i => i.user).FirstOrDefaultAsync(i => i.RecipesId == id && i.user.Id.Equals(uid));
    }

    public async Task<UserRecipiesEntity> getUserRecipiesById(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<UserRecipiesEntity> addUserRecipies(UserRecipiesModel model)
    {
        throw new NotImplementedException();
    }

    public async Task<UserRecipiesEntity> updateUserRecipies(UserRecipiesModel model)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> deleteUserRecipies(int id)
    {
        throw new NotImplementedException();
    }
}