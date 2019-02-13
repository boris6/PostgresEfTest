using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Postgres.Domain.Entities;
using Postgres.Persistance;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostGresWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentitiesController : ControllerBase
    {
        private readonly FrcContext _context;

        public IdentitiesController(FrcContext context)
        {
            _context = context;
        }

        // GET: api/Identities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Identity>>> GetIdentities()
        {
            return await _context.Identities.ToListAsync();
        }

        // GET: api/Identities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Identity>> GetIdentity(int id)
        {
            var identity = await _context.Identities.FindAsync(id);

            if (identity == null)
            {
                return NotFound();
            }

            return identity;
        }

        // PUT: api/Identities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdentity(int id, Identity identity)
        {
            if (id != identity.IdentityId)
            {
                return BadRequest();
            }

            _context.Entry(identity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdentityExists(id))
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

        // POST: api/Identities
        [HttpPost]
        public async Task<ActionResult<Identity>> PostIdentity(Identity identity)
        {
            _context.Identities.Add(identity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIdentity", new { id = identity.IdentityId }, identity);
        }

        // DELETE: api/Identities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Identity>> DeleteIdentity(int id)
        {
            var identity = await _context.Identities.FindAsync(id);
            if (identity == null)
            {
                return NotFound();
            }

            _context.Identities.Remove(identity);
            await _context.SaveChangesAsync();

            return identity;
        }

        private bool IdentityExists(int id)
        {
            return _context.Identities.Any(e => e.IdentityId == id);
        }
    }
}