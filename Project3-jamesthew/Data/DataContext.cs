using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<FeedbackEntity> feedbacks { get; set; }
        public DbSet<TipsEntity> tipsEntities { get; set; }
        public DbSet<CategoryEntity> categories { get; set; }
        public DbSet<RecipesEntity> recipes { get; set; }
        public DbSet<UserIngredientEntity> usersIngredients { get; set; }
        public DbSet<ContestEntity> contests { get; set; }
        public DbSet<RecipesCompetitionEntity> recipesCompetitions { get; set; }
    }
}
