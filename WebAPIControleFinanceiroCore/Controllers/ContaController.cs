using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIControleFinanceiroCore.Data;
using WebAPIControleFinanceiroCore.Model;

namespace WebAPIControleFinanceiroCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conta>>> GetContas()
        {
            return await _context.Contas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conta>> GetConta(int id)
        {
            var product = await _context.Contas.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Conta>> PostConta(Conta conta)
        {
            if (conta.DataVencimento.Kind == DateTimeKind.Unspecified)
            {
                // Ajustar o DateTime para UTC, se necessário
                conta.DataVencimento = DateTime.SpecifyKind(conta.DataVencimento, DateTimeKind.Utc);
            }

            try
            {
                _context.Contas.Add(conta);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetConta), new { id = conta.Id }, conta);
            }
            catch (Exception ex)
            {
                // Log e manipular o erro adequadamente
                return BadRequest(new { message = "Erro ao salvar a conta.", error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConta(int id, Conta conta)
        {
            if (id != conta.Id)
            {
                return BadRequest();
            }

            _context.Entry(conta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaExists(id))
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
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Contas.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Contas.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaExists(int id)
        {
            return _context.Contas.Any(e => e.Id == id);
        }
    }
}
