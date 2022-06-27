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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesRepository _repository;
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public CategoryController(ICategoriesRepository repository, DataContext context, IWebHostEnvironment hostEnvironment)
        {
            this._repository = repository;
            this._context = context;
            _hostEnvironment = hostEnvironment;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryEntity>>> GetAllCate()
        {
            try
            {
                return await _context.categories.Select(x => new CategoryEntity()
                {
                    CategoryId = x.CategoryId,
                    CategoryName = x.CategoryName,
                    CategoryDescription = x.CategoryDescription,
                    CategoryIcon = x.CategoryIcon,
                    CategoryImg = x.CategoryImg,
                    ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.CategoryImg)
                }).ToListAsync();
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
        public async Task<IActionResult> AddCate([FromForm] CategoryEntity cate)
        {
            try
            {
                if(cate != null)
                {
                    cate.CategoryImg= await SaveImage(cate.ImageFile);
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
        public async Task<IActionResult> UpdateCate(int id , [FromForm] CategoryEntity cate)
        {
              if(id!= cate.CategoryId)
                {
                    return BadRequest();
                }
                if(cate.ImageFile!= null)
                {
                    DeleteImage(cate.CategoryImg);
                    cate.CategoryImg = await SaveImage(cate.ImageFile);     
                }
                  _context.Entry(cate).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CateModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCate(int id)
        {
            try
            {
                var cateDelete = await _repository.GetCategoryById(id);
                if (cateDelete != null)
                {
                    DeleteImage(cateDelete.CategoryImg);
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
        private bool CateModelExists(int id)
        {
            return _context.categories.Any(e => e.CategoryId == id);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }

        [NonAction]
        public void DeleteImage(string imageName)
        {
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
        }
    }
}
