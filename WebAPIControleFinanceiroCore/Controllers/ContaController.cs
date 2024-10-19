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
            var conta = await _context.Contas.FindAsync(id);

            if (conta == null)
            {
                return NotFound();
            }

            return conta;
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

        [HttpPost("edit")]
        public async Task<IActionResult> EditConta([FromBody] Conta conta)
        {
            if (conta == null || conta.Id <= 0)
            {
                return BadRequest();
            }

            var existingConta = await _context.Contas.FindAsync(conta.Id);

            if (existingConta == null)
            {
                return NotFound();
            }

            // Atualize as propriedades da conta existente
            existingConta.Nome = conta.Nome;
            existingConta.Valor = conta.Valor;
            existingConta.DataVencimento = conta.DataVencimento.ToUniversalTime(); // Converta para UTC
            existingConta.DataPagamento = conta.DataPagamento?.ToUniversalTime(); // Converta para UTC
            existingConta.Pago = conta.DataPagamento.HasValue ? true : existingConta.Pago;

            _context.Entry(existingConta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaExists(conta.Id))
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
        public async Task<IActionResult> DeleteConta(int id)
        {
            var conta = await _context.Contas.FindAsync(id);
            if (conta == null)
            {
                return NotFound();
            }

            _context.Contas.Remove(conta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("reopen/{id}")]
        public async Task<IActionResult> ReopenConta(int id)
        {
            var conta = await _context.Contas.FindAsync(id);

            if (conta == null)
            {
                return NotFound();
            }

            conta.DataVencimento = conta.DataVencimento.ToUniversalTime(); // Converta para UTC
            conta.DataPagamento = null;
            conta.Pago = false;

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

        [HttpPost("pay/{id}")]
        public async Task<IActionResult> PayConta(int id, [FromBody] DateTime paymentDate)
        {
            // Buscando a conta pelo ID
            var conta = await _context.Contas.FindAsync(id);

            // Verificando se a conta existe
            if (conta == null)
            {
                return NotFound(new { Message = "Conta não encontrada." });
            }

            conta.DataVencimento = conta.DataVencimento.ToUniversalTime(); // Converta para UTC
            conta.DataPagamento = paymentDate.ToUniversalTime(); // Converta para UTC
            conta.Pago = true; // Definindo o status como pago

            // Informando ao EF que a conta foi modificada
            _context.Entry(conta).State = EntityState.Modified;

            try
            {
                // Salvando as alterações no banco de dados
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaExists(id))
                {
                    return NotFound(new { Message = "Conta não encontrada durante a atualização." });
                }
                else
                {
                    // Logue a exceção aqui se necessário
                    return StatusCode(500, new { Message = "Erro interno ao tentar pagar a conta." });
                }
            }

            // Retorna uma resposta sem conteúdo após uma operação bem-sucedida
            return NoContent();
        }

        private bool ContaExists(int id)
        {
            return _context.Contas.Any(e => e.Id == id);
        }
    }
}
