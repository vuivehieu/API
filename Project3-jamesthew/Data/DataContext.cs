using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Data
{
    public class DataContext : IdentityDbContext  
    {
        public DataContext(DbContextOptions options) : base(options)
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
        public DbSet<IngredientEntity> ingredients { get; set; }
        public DbSet<AnnounceEntity> announces { get; set; }
        public DbSet<ContactEntity> contacts { get; set; }
        public DbSet<FaqEntity> faqs { get; set; }
       /* public DbSet<UserRecipiesEntity> userRecipies { get; set; }*/
    }
}
