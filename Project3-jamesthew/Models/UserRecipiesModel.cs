using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Models;

public class UserRecipiesModel
{
    public int RecipesId { get; set; }
    public int PrepationTime { get; set; }
    public int CookingTime { get; set; }
    public EDifficulty Difficulty { get; set; }
    public int Serve { get; set; }
    public int Calories { get; set; }
    public int Proteins { get; set; }
    public int Carbs { get; set; }
    public int Fat { get; set; }
    public int SaturatedFat { get; set; }
    public int Fiber { get; set; }
    public int Sugar { get; set; }
    public int Salt { get; set; }
    public int CategoriesId  { get; set; }
    public string RecipesPic { get; set; }
    public string RecipesTitle { get; set; }
    public string RecipesDescription { get; set; }
    public bool IsPaid { get; set; }
    public DateTime SubmitDate { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
}