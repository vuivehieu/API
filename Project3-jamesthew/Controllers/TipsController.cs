using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsController : ControllerBase
    {
        private readonly ITipsRepository _repository;
        public TipsController(ITipsRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTips()
        {
            try
            {
                return Ok(await _repository.GetAllTips());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipsById(int id)
        {
            try
            {
                var result = await _repository.GetTipsById(id);
                if(result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddTips(TipsEntity tips)
        {
            try
            {
                if(tips == null)
                {
                    return BadRequest();
                }
                var result = await _repository.AddTips(tips);
                return Ok(result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTips(int id,TipsEntity tips)
        {
            try
            {
                if (id != tips.TipsId)
                {
                    return BadRequest();
                }
                var tipsUpdate = await _repository.GetTipsById(id);
                if (tipsUpdate != null)
                {
                    var result = await _repository.UpdateTips(tips);
                    return Ok(result);
                }
                return NotFound($"This tips with Id = {id} not found");
            }catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating data");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTips(int id)
        {
            try
            {
              var tipsDelete = await _repository.GetTipsById(id);   
                if(tipsDelete != null)
                {
                    await _repository.DeleteTips(id);
                     return Ok();
                }
                return NotFound($"Tips with Id = {id} not found");
            }
            catch (Exception)
            {
                return BadRequest( "Error updating data");
            }
        }


    }
}
