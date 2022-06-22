using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.DataTransferObjects;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserIgredientController : ControllerBase
    {
        private readonly IUserIngredientRepository _repository;
        public UserIgredientController(IUserIngredientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIngredient()
        {
            try
            {
                return Ok(await _repository.GetAllUserIgre());
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
                var result = await _repository.GetUserIgreById(id);
                if (result != null)
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
        public async Task<IActionResult> AddUserIngre(UserIgredientDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserIngredientEntity entity = new UserIngredientEntity
                    {
                        IngredientName = model.IngredientName,
                        Quantity = model.Quantity,
                        RecipesId = model.RecipesId,
                    };
                    var result = await _repository.AddUserIgre(entity);
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserIngre(int? id,UserIgredientDto model)
        {
            try
            {
                 if (id == null)
                {
                    return NotFound();
                }
                var ingreUpdate = await _repository.GetUserIgreById(id.Value);
                if(ingreUpdate != null)
                {
                    UserIngredientEntity entity = new UserIngredientEntity
                    {
                        IngredientId = model.IngredientId,
                        IngredientName = model.IngredientName,
                        Quantity = model.Quantity,
                        RecipesId = model.RecipesId,
                    };
                    var result = await _repository.UpdateUserIgre(entity);
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            try
            {
                var userIngre = await _repository.GetUserIgreById(id);
                if (userIngre != null)
                {
                    await _repository.DeleteUserIgre(id);
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
