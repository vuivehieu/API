using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.DataTransferObjects;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnounceController : ControllerBase
    {
        private readonly IAnnounceRepository _repository;
        public AnnounceController(IAnnounceRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAllAnnounce());
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
                var result = await _repository.GetCAnnounceById(id);
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
        public async Task<IActionResult> AddAnnounce(AnnounceDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AnnounceEntity entity = new AnnounceEntity
                    {
                        AnnounceDate = model.AnnounceDate,
                        Email = model.Email,
                        ContestId = model.ContestId,
                        RecipeCompetitionId = model.RecipeCompetitionId
                        
                    };
                    var result = await _repository.AddAnnounce(entity);
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
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnnounce(int? id , AnnounceDto model)
        {
            try
            {
            if(id == null)
                    {
                        return NotFound();
                    }
                    var getId = await _repository.GetCAnnounceById(id.Value);
                    if(getId != null)
                    {
                        AnnounceEntity entity = new AnnounceEntity
                        {
                            AnnounceId = model.AnnounceId,
                            AnnounceDate = model.AnnounceDate,
                            Email = model.Email,
                            ContestId = model.ContestId,
                            RecipeCompetitionId = model.RecipeCompetitionId
                        };
                        var result = await _repository.UpdateAnnounce(entity);
                        return Ok(result);
                    }
                return NotFound($" Id = {id} not found");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnounce(int id)
        {
            try
            {
                var getId = await _repository.GetCAnnounceById(id);
                if(getId != null)
                {
                     await _repository.DeleteAnnounce(id);
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
