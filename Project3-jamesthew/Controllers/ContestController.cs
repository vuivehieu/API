using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.DataTransferObjects;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContestController : ControllerBase
    {
        private readonly IContestRepository _repository;
        public ContestController(IContestRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAllContest());
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
                var result = await _repository.GetContestById(id);
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
        public async Task<IActionResult> AddContest(ContestDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ContestEntity entity = new ContestEntity
                    {
                        ContestId = model.ContestId,
                        ContestTitle = model.ContestTitle,
                        ContestStart = model.ContestStart,
                        ContestEnd = model.ContestEnd,
                        CategoryId = model.CategoryId,
                        ContestDescription = model.ContestDescription,
                        IsOpen = model.IsOpen,
                    };
                    var result = await _repository.AddContest(entity);
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
        public async Task<IActionResult> UpdateContest(int? id,ContestDto model)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                var resultUp = await _repository.GetContestById(id.Value);
                if(resultUp != null)
                {
                    ContestEntity entity = new ContestEntity
                    {
                        ContestId = model.ContestId,
                        ContestTitle = model.ContestTitle,
                        ContestStart = model.ContestStart,
                        ContestEnd = model.ContestEnd,
                        CategoryId = model.CategoryId,
                        ContestDescription = model.ContestDescription,
                        IsOpen = model.IsOpen,
                    };
                    var result = await _repository.UpdateContest(entity);
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
        [HttpDelete]
        public async Task<IActionResult> DeleteContest(int id)
        {
            try
            {
                var contestDelete = await _repository.GetContestById(id);
                if(contestDelete != null)
                {
                    await _repository.DeleteContest(id);
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
