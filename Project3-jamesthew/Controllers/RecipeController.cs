using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.DataTransferObjects;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _repository;
        public RecipeController(IRecipeRepository repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRecipe()
        {
            try
            {
                return Ok(await _repository.GetAllRecipes());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipeById(int id)
        {
            try
            {
                var result = await _repository.GetRecipeById(id);
                if(result != null)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error retrieving data from the database");
            }
        }
 
        
        [HttpPost]
        public async Task<IActionResult> CreateRecipe(RecipesDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RecipesEntity recipe = new RecipesEntity
                    {
                        PrepationTime = model.PrepationTime,
                        CookingTime = model.CookingTime,
                        Serve = model.Serve,
                        Calories = model.Calories,
                        Difficulty = model.Difficulty,
                        Proteins = model.Proteins,
                        Carbs = model.Carbs,
                        Fat = model.Fat,
                        SaturatedFat = model.SaturatedFat,
                        Fiber = model.Fiber,
                        Sugar = model.Sugar,
                        Salt = model.Salt,
                        RecipesPic = model.RecipesPic,
                        RecipesTitle = model.RecipesTitle,
                        RecipesDescription = model.RecipesDescription,
                        IsPaid = model.IsPaid,
                        CategoriesId = model.CategoriesId,
                    };
                    var result = await _repository.AddRecipe(recipe);
                    return Ok(result);
                }
                return BadRequest();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from the database");
            }
           

        }

        [HttpPut("{id}")]
          public async Task<IActionResult> UpdateRecipes(int? id, RecipesDto model)
        {
            try
            {
                if(id == null)
                {
                    return NotFound();
                }
                var reciUpdate = await _repository.GetRecipeById(id.Value);
                if(reciUpdate !=null)
                {
                   RecipesEntity recipe = new RecipesEntity
                    {
                        RecipesId = model.RecipesId,
                        PrepationTime = model.PrepationTime,
                        CookingTime = model.CookingTime,
                        Serve = model.Serve,
                        Calories = model.Calories,
                        Difficulty = model.Difficulty,
                        Proteins = model.Proteins,
                        Carbs = model.Carbs,
                        Fat = model.Fat,
                        SaturatedFat = model.SaturatedFat,
                        Fiber = model.Fiber,
                        Sugar = model.Sugar,
                        Salt = model.Salt,
                        RecipesPic = model.RecipesPic,
                        RecipesTitle = model.RecipesTitle,
                        RecipesDescription = model.RecipesDescription,
                        IsPaid = model.IsPaid,
                        CategoriesId = model.CategoriesId,
                    };
                    var result =  await _repository.UpdateRecipe(recipe);
                    return Ok(result);
                }
                return NotFound($"This recipe with Id = {id} not found");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from the database");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            try
            {
                var recipeDelete = await _repository.GetRecipeById(id);
                if (recipeDelete != null)
                {
                    await _repository.DeleteRecipe(id);
                    return Ok();
                }
                return NotFound($"Id = {id} not found");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }

    }
}