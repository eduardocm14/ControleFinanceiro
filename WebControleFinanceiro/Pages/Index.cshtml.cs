using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppControleFinanceiro.Services;
using WebControleFinanceiro.Model;

namespace WebAppControleFinanceiro.Pages
{
    public class IndexModel(ContaService contaService) : PageModel
    {
        private readonly ContaService _contaService = contaService;

        public IEnumerable<Conta> Contas { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? EndDate { get; set; }

        [BindProperty]
        public Conta Conta { get; set; } // Modelo da conta

        public async Task OnGetAsync()
        {
            DateTime defaultStartDate = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime defaultEndDate = new(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            // var dateFilter = Request.Query["DateFilter"];
            // var filterType = Request.Query["FilterType"];
            var startDateString = Request.Query["StartDate"];
            var endDateString = Request.Query["EndDate"];

            DateTime startDate = DateTime.TryParse(startDateString, out var parsedStartDate) ? parsedStartDate : defaultStartDate;
            DateTime endDate = DateTime.TryParse(endDateString, out var parsedEndDate) ? parsedEndDate : defaultEndDate;

            endDate = endDate.Date.AddDays(1).AddTicks(-1);

            StartDate = startDate;
            EndDate = endDate;

            Contas = await _contaService.GetContasAsync(StartDate, EndDate) ?? new List<Conta>(); ;
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var success = await _contaService.DeleteContaAsync(id);

            if (success)
            {
                // Recarregar a lista de contas após a exclusão
                Contas = await _contaService.GetContasAsync(StartDate, EndDate);
                return RedirectToPage(); // Redirecionar para atualizar a página
            }

            // Caso a exclusão não tenha sido bem-sucedida, exibir uma mensagem ou tomar alguma ação
            ModelState.AddModelError(string.Empty, "Não foi possível excluir a conta.");
            return Page();
        }
    }
}
