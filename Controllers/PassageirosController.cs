using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AndreAirlinesAPI.Data;
using AndreAirlinesAPI.Model;
using AndreAirlinesAPI.Services;

namespace AndreAirlinesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassageirosController : ControllerBase
    {
        private readonly AndreAirlinesAPIContext _context;

        public PassageirosController(AndreAirlinesAPIContext context)
        {
            _context = context;
        }

        // GET: api/Passageiroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passageiro>>> GetPassageiro()
        {
            return await _context.Passageiro.Include(e => e.Endereco).ToListAsync();
        }

        // GET: api/Passageiroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passageiro>> GetPassageiro(int id)
        {
            var passageiro = await _context.Passageiro.Include(e => e.Endereco).FirstOrDefaultAsync();

            if (passageiro == null)
            {
                return NotFound();
            }

            return passageiro;
        }

        // PUT: api/Passageiroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassageiro(string id, Passageiro passageiro)
        {
            if (id != passageiro.CPF)
            {
                return BadRequest();
            }

            _context.Entry(passageiro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassageiroExists(id))
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

        // POST: api/Passageiroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Passageiro>> PostPassageiro(Passageiro passageiro)
        {
            var endereco = await ApiCep.ViaCepJsonAsync(passageiro.Endereco.CEP);
            string logradouro = endereco.Logradouro;
            string bairro = endereco.Bairro;
            string localidade = endereco.Localidade;
            string uf = endereco.UF;
            string complemento = endereco.Complemento;
            //payLoad retorno do serviço
            
            passageiro.Endereco.Logradouro = logradouro;
            passageiro.Endereco.Bairro = bairro;
            passageiro.Endereco.Localidade = localidade;
            passageiro.Endereco.UF = uf;
            passageiro.Endereco.Complemento = complemento;
            
            _context.Passageiro.Add(passageiro);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PassageiroExists(passageiro.CPF))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPassageiro", new { id = passageiro.CPF }, passageiro);
        }

        // DELETE: api/Passageiroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassageiro(string id)
        {
            var passageiro = await _context.Passageiro.FindAsync(id);
            if (passageiro == null)
            {
                return NotFound();
            }

            _context.Passageiro.Remove(passageiro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PassageiroExists(string id)
        {
            return _context.Passageiro.Any(e => e.CPF == id);
        }
    }
}
