using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIControleFinanceiroCore.Data;
using WebAPIControleFinanceiroCore.Model;

namespace WebAPIControleFinanceiroCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoAluguelController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContratoAluguel>>> GetContratosAlugueis()
        {
            return await _context.ContratosAlugueis.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContratoAluguel>> GetContratoAluguel(int id)
        {
            var contratoAluguel = await _context.ContratosAlugueis.FindAsync(id);

            if (contratoAluguel == null)
            {
                return NotFound();
            }

            return contratoAluguel;
        }

        [HttpPost]
        public async Task<ActionResult<ContratoAluguel>> PostContratoAluguel(ContratoAluguel contratoAluguel)
        {
            try
            {
                _context.ContratosAlugueis.Add(contratoAluguel);

                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetContratoAluguel), new { id = contratoAluguel.Id }, contratoAluguel);
            }
            catch (Exception ex)
            {
                // Log e manipular o erro adequadamente
                return BadRequest(new { message = "Erro ao salvar a conta.", error = ex.Message });
            }
        }

        [HttpPost("edit")]
        public async Task<IActionResult> EditContratoAluguel([FromBody] ContratoAluguel contratoAluguel)
        {
            if (contratoAluguel == null || contratoAluguel.Id <= 0)
            {
                return BadRequest();
            }

            _context.Entry(contratoAluguel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratoAluguelExists(contratoAluguel.Id))
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
        public async Task<IActionResult> DeleteContratoAluguel(int id)
        {
            var contratoAluguel = await _context.ContratosAlugueis.FindAsync(id);

            if (contratoAluguel == null)
            {
                return NotFound();
            }

            _context.ContratosAlugueis.Remove(contratoAluguel);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContratoAluguelExists(int id)
        {
            return _context.ContratosAlugueis.Any(e => e.Id == id);
        }
    }
}
