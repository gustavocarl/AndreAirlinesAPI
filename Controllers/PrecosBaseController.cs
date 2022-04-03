using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AndreAirlinesAPI.Data;
using AndreAirlinesAPI.Model;

namespace AndreAirlinesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrecosBaseController : ControllerBase
    {
        private readonly AndreAirlinesAPIContext _context;

        public PrecosBaseController(AndreAirlinesAPIContext context)
        {
            _context = context;
        }

        // GET: api/PrecosBase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrecoBase>>> GetPrecoBase()
        {
            return await _context.PrecoBase.ToListAsync();
        }

        // GET: api/PrecosBase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrecoBase>> GetPrecoBase(int id)
        {
            var precoBase = await _context.PrecoBase.FindAsync(id);

            if (precoBase == null)
            {
                return NotFound();
            }

            return precoBase;
        }

        // PUT: api/PrecosBase/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrecoBase(int id, PrecoBase precoBase)
        {
            if (id != precoBase.Id)
            {
                return BadRequest();
            }

            _context.Entry(precoBase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrecoBaseExists(id))
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

        // POST: api/PrecosBase
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrecoBase>> PostPrecoBase(PrecoBase precoBase)
        {
            _context.PrecoBase.Add(precoBase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrecoBase", new { id = precoBase.Id }, precoBase);
        }

        // DELETE: api/PrecosBase/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrecoBase(int id)
        {
            var precoBase = await _context.PrecoBase.FindAsync(id);
            if (precoBase == null)
            {
                return NotFound();
            }

            _context.PrecoBase.Remove(precoBase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrecoBaseExists(int id)
        {
            return _context.PrecoBase.Any(e => e.Id == id);
        }
    }
}
