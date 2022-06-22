using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Repository;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesRepository _repository;
        public CategoryController(ICategoriesRepository repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCate(string? search)
        {
            try
            {
                return Ok(await _repository.GetAllCategory(search));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCateById(int id)
        {
            try
            {
                var result = await _repository.GetCategoryById(id);
                if(result != null)
                {
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
        [HttpPost]
        public async Task<IActionResult> AddCate(CategoryEntity cate)
        {
            try
            {
                if(cate != null)
                {
                    var result = await _repository.AddCategory(cate);
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
        public async Task<IActionResult> UpdateCate(int id ,CategoryEntity cate)
        {
            try
            {
                if(id!= cate.CategoryId)
                {
                    return BadRequest();
                }
                var cateUpdate = await _repository.GetCategoryById(id);
                if(cateUpdate!= null)
                {
                    var result = await _repository.UpdateCategory(cate);
                    return Ok(result);
                }
                return NotFound($"This cate with Id = {id} not found");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCate(int id)
        {
            try
            {
                var cateDelete = await _repository.GetCategoryById(id);
                if (cateDelete != null)
                {
                    await _repository.DeleteCategory(id);
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
