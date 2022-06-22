using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.DataTransferObjects;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesCompetitionController : ControllerBase
    {
        private readonly IRecipesCompeRepository _repository;
        public RecipesCompetitionController(IRecipesCompeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAllRecipesCompe());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _repository.GetRecipesCompeById(id);
                if(result != null)
                {
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
        [HttpPost]
        public async Task<IActionResult> AddRecipeCompetition(RecipesCompetitionDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RecipesCompetitionEntity entity = new RecipesCompetitionEntity
                    {
                
                        PrepationTime = model.PrepationTime,
                        CookingTime = model.CookingTime,
                        Difficulty = model.Difficulty,
                        Serve = model.Serve,
                        Calories = model.Calories,
                        Proteins = model.Proteins,
                        Carbs = model.Carbs,
                        Fat = model.Fat,
                        SaturatedFat = model.SaturatedFat,
                        Fiber = model.Fiber,
                        Sugar = model.Sugar,
                        Salt = model.Salt,
                        ContestId = model.ContestId,
                        RecipesPic = model.RecipesPic,
                        RecipesTitle = model.RecipesTitle,
                        RecipesDescription = model.RecipesDescription,
                        UserName = model.UserName,
                        UserEmail = model.UserEmail,
                        SubmitDate = model.SubmitDate,
                        Winner = model.Winner,
                        UserPic = model.UserPic,
                        UserDescription = model.UserDescription
                    };
                    var result = await _repository.AddRecipesCompe(entity);
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
        public async Task<IActionResult> UpdateRecipeCompetition(int? id, RecipesCompetitionDto model)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var reciUpdate = await _repository.GetRecipesCompeById(id.Value);
                if (reciUpdate != null) {
                    RecipesCompetitionEntity entity = new RecipesCompetitionEntity
                    {
                        RecipesCompetitionId = model.RecipesCompetitionId,
                        PrepationTime = model.PrepationTime,
                        CookingTime = model.CookingTime,
                        Difficulty = model.Difficulty,
                        Serve = model.Serve,
                        Calories = model.Calories,
                        Proteins = model.Proteins,
                        Carbs = model.Carbs,
                        Fat = model.Fat,
                        SaturatedFat = model.SaturatedFat,
                        Fiber = model.Fiber,
                        Sugar = model.Sugar,
                        Salt = model.Salt,
                        ContestId = model.ContestId,
                        RecipesPic = model.RecipesPic,
                        RecipesTitle = model.RecipesTitle,
                        RecipesDescription = model.RecipesDescription,
                        UserName = model.UserName,
                        UserEmail = model.UserEmail,
                        SubmitDate = model.SubmitDate,
                        Winner = model.Winner,
                        UserPic = model.UserPic,
                        UserDescription = model.UserDescription
                    };
                    var result = await _repository.UpdateRecipesCompe(entity);
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
        [HttpDelete]
        public async Task<IActionResult> DeleteRecipesCompe(int id)
        {
            try
            {
                var result = await _repository.GetRecipesCompeById(id);
                if(result != null)
                {
                    await _repository.DeleteRecipesCompetition(id);
                    return Ok();
                }
                return NotFound($"Id = {id} not found");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }
     
    }
}
