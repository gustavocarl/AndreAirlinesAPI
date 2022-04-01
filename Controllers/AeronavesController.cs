﻿using System;
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
    public class AeronavesController : ControllerBase
    {
        private readonly AndreAirlinesAPIContext _context;

        public AeronavesController(AndreAirlinesAPIContext context)
        {
            _context = context;
        }

        // GET: api/Aeronaves
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aeronave>>> GetAeronave()
        {
            return await _context.Aeronave.ToListAsync();
        }

        // GET: api/Aeronaves/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aeronave>> GetAeronave(string id)
        {
            var aeronave = await _context.Aeronave.FindAsync(id);

            if (aeronave == null)
            {
                return NotFound();
            }

            return aeronave;
        }

        // PUT: api/Aeronaves/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAeronave(string id, Aeronave aeronave)
        {
            if (id != aeronave.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(aeronave).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AeronaveExists(id))
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

        // POST: api/Aeronaves
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aeronave>> PostAeronave(Aeronave aeronave)
        {
            _context.Aeronave.Add(aeronave);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AeronaveExists(aeronave.Codigo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAeronave", new { id = aeronave.Codigo }, aeronave);
        }

        // DELETE: api/Aeronaves/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAeronave(string id)
        {
            var aeronave = await _context.Aeronave.FindAsync(id);
            if (aeronave == null)
            {
                return NotFound();
            }

            _context.Aeronave.Remove(aeronave);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AeronaveExists(string id)
        {
            return _context.Aeronave.Any(e => e.Codigo == id);
        }
    }
}
