using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqController : ControllerBase
    {
        private readonly DataContext _context;

        public FaqController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Faq
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaqEntity>>> Getfaq()
        {
            if (_context.faqs == null)
            {
                return NotFound();
            }
            return await _context.faqs.ToListAsync();
        }

        // GET: api/Faq/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FaqEntity>> GetFaqEntity(int id)
        {
            if (_context.faqs == null)
            {
                return NotFound();
            }
            var faqEntity = await _context.faqs.FindAsync(id);

            if (faqEntity == null)
            {
                return NotFound();
            }

            return faqEntity;
        }

        // PUT: api/Faq/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaqEntity(int id, FaqEntity faqEntity)
        {
            if (id != faqEntity.FaqId)
            {
                return BadRequest();
            }

            _context.Entry(faqEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaqEntityExists(id))
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

        // POST: api/Faq
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FaqEntity>> PostFaqEntity(FaqEntity faqEntity)
        {
            if (_context.faqs == null)
            {
                return Problem("Entity set 'DataContext.faq'  is null.");
            }
            _context.faqs.Add(faqEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaqEntity", new { id = faqEntity.FaqId }, faqEntity);
        }

        // DELETE: api/Faq/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaqEntity(int id)
        {
            if (_context.faqs == null)
            {
                return NotFound();
            }
            var faqEntity = await _context.faqs.FindAsync(id);
            if (faqEntity == null)
            {
                return NotFound();
            }

            _context.faqs.Remove(faqEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaqEntityExists(int id)
        {
            return (_context.faqs?.Any(e => e.FaqId == id)).GetValueOrDefault();
        }
    }
}
