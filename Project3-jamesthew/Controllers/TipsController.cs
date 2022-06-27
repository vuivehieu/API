using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsController : ControllerBase
    {
        private readonly ITipsRepository _repository;
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public TipsController(ITipsRepository repository,DataContext context,IWebHostEnvironment hostEnvironment)
        {
            this._repository = repository;
            this._context = context;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipsEntity>>> GetTips()
        {
            try
            {
                return await _context.tipsEntities.Select(x => new TipsEntity()
                {
                    TipsId = x.TipsId,
                    TipsTitle = x.TipsTitle,
                    TipsDescription = x.TipsDescription,    
                    TipsImage = x.TipsImage,
                    ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.TipsImage)
                }).ToListAsync();
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
        public async Task<IActionResult> AddTips([FromForm] TipsEntity tips)
        {
            try
            {
                if(tips == null)
                {
                    return BadRequest();
                }
                tips.TipsImage = await _repository.SaveImage(tips.ImageFile);
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
        public async Task<IActionResult> UpdateTips(int id, [FromForm] TipsEntity tips)
        {
            try
            {
                if (id != tips.TipsId)
                {
                    return BadRequest();
                }
               
                if (tips.ImageFile != null)
                {
                    _repository.DeleteImage(tips.TipsImage);
                    tips.TipsImage = await _repository.SaveImage(tips.ImageFile);
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
                    _repository.DeleteImage(tipsDelete.TipsImage);
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
