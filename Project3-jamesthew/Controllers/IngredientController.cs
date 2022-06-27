using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.DataTransferObjects;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _repository;
        public IngredientController(IIngredientRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAllIngredient());
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
                var getId = await _repository.GetIngredientById(id);
                if(getId != null)
                {
                    return Ok(getId);   
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
        public async Task<IActionResult> AddIngredient(IngredientDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IngredientEntity entity = new IngredientEntity
                    {
                        IngredientName = model.IngredientName,
                        Quantity = model.Quantity,
                        RecipeCompetitionId = model.RecipeCompetitionId,
                    };
                    var result = await _repository.AddIngredient(entity);
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            try
            {
                var getId = await _repository.GetIngredientById(id);
                if(getId != null)
                {
                    await _repository.DeleteIngredient(id);
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
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int? id ,IngredientDto model)
        {
            try
            {
                if(id == null)
                {
                    return NotFound();
                }
                var getId = await _repository.GetIngredientById(id.Value);
                if(getId != null)
                {
                    IngredientEntity entity = new IngredientEntity
                    {
                        IngredientId = model.IngredientId,
                        IngredientName = model.IngredientName,
                        Quantity = model.Quantity,
                        RecipeCompetitionId = model.RecipeCompetitionId,
                    };
                    var result = await _repository.UpdateIngredient(entity);
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
    }
}
