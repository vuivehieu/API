using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ContactEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactEntity>>> Getcontacts()
        {
            if (_context.contacts == null)
            {
                return NotFound();
            }
            return await _context.contacts.ToListAsync();
        }

        // GET: api/ContactEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactEntity>> GetContactEntity(int id)
        {
            if (_context.contacts == null)
            {
                return NotFound();
            }
            var contactEntity = await _context.contacts.FindAsync(id);

            if (contactEntity == null)
            {
                return NotFound();
            }

            return contactEntity;
        }

        // PUT: api/ContactEntities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactEntity(int id, ContactEntity contactEntity)
        {
            if (id != contactEntity.ContactId)
            {
                return BadRequest();
            }

            _context.Entry(contactEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactEntityExists(id))
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

        // POST: api/ContactEntities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactEntity>> PostContactEntity(ContactEntity contactEntity)
        {
            if (_context.contacts == null)
            {
                return Problem("Entity set 'DataContext.contacts'  is null.");
            }
            _context.contacts.Add(contactEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactEntity", new { id = contactEntity.ContactId }, contactEntity);
        }

        // DELETE: api/ContactEntities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactEntity(int id)
        {
            if (_context.contacts == null)
            {
                return NotFound();
            }
            var contactEntity = await _context.contacts.FindAsync(id);
            if (contactEntity == null)
            {
                return NotFound();
            }

            _context.contacts.Remove(contactEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactEntityExists(int id)
        {
            return (_context.contacts?.Any(e => e.ContactId == id)).GetValueOrDefault();
        }
    }
}
