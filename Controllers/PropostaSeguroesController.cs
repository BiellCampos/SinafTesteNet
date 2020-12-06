using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SinafTeste.Context;
using SinafTeste.Models;

namespace SinafTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropostaSegurosController : ControllerBase
    {
        private readonly SinafTestContext _context;

        public PropostaSegurosController(SinafTestContext context)
        {
            _context = context;
        }

        // GET: api/PropostaSeguroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropostaSeguro>>> GetPropostaSeguro()
        {
            return await _context.PropostaSeguro.ToListAsync();
        }

        // GET: api/PropostaSeguroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PropostaSeguro>> GetPropostaSeguro(int id)
        {
            var propostaSeguro = await _context.PropostaSeguro.FindAsync(id);

            if (propostaSeguro == null)
            {
                return NotFound();
            }

            return propostaSeguro;
        }

        // PUT: api/PropostaSeguroes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropostaSeguro(int id, PropostaSeguro propostaSeguro)
        {
            if (id != propostaSeguro.IdPropostaSeguro)
            {
                return BadRequest();
            }

            _context.Entry(propostaSeguro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropostaSeguroExists(id))
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

        // POST: api/PropostaSeguroes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PropostaSeguro>> PostPropostaSeguro(PropostaSeguro propostaSeguro)
        {
            _context.PropostaSeguro.Add(propostaSeguro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPropostaSeguro", new { id = propostaSeguro.IdPropostaSeguro }, propostaSeguro);
        }

        // DELETE: api/PropostaSeguroes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PropostaSeguro>> DeletePropostaSeguro(int id)
        {
            var propostaSeguro = await _context.PropostaSeguro.FindAsync(id);
            if (propostaSeguro == null)
            {
                return NotFound();
            }

            _context.PropostaSeguro.Remove(propostaSeguro);
            await _context.SaveChangesAsync();

            return propostaSeguro;
        }

        private bool PropostaSeguroExists(int id)
        {
            return _context.PropostaSeguro.Any(e => e.IdPropostaSeguro == id);
        }
    }
}
