using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using WebAppControleFinanceiro.Services;
using WebControleFinanceiro.Model;

namespace WebAppControleFinanceiro.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ContaService _contaService;

        public IndexModel(ContaService contaService)
        {
            _contaService = contaService;
        }

        public IEnumerable<Conta> Contas { get; set; } = [];

        [BindProperty(SupportsGet = true)]
        public DateTime? StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? EndDate { get; set; }

        [BindProperty]
        public Conta Conta { get; set; } // Modelo da conta

        [BindProperty(SupportsGet = true)]
        public string? DateFilter { get; set; }

        //[BindProperty(SupportsGet = true)]
        //public string FilterType { get; set; }

        public async Task OnGetAsync()
        {
            DateTime defaultStartDate = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime defaultEndDate = new(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            var startDateString = Request.Query["StartDate"];
            var endDateString = Request.Query["EndDate"];

            DateTime startDate = DateTime.TryParse(startDateString, out var parsedStartDate) ? parsedStartDate : defaultStartDate;
            DateTime endDate = DateTime.TryParse(endDateString, out var parsedEndDate) ? parsedEndDate : defaultEndDate;

            endDate = endDate.Date.AddDays(1).AddTicks(-1);

            // Ajusta as datas com base no filtro selecionado
            switch (DateFilter)
            {
                case "Last7Days":
                    endDate = startDate.AddDays(7);
                    break;
                case "Last15Days":
                    endDate = startDate.AddDays(15);
                    break;
                case "Last20Days":
                    endDate = startDate.AddDays(20);
                    break;
                case "ThisMonth":
                    endDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
                    break;
                default:
                    break;
            }

            StartDate = startDate;
            EndDate = endDate;

            Contas = await _contaService.GetContasAsync(StartDate, EndDate) ?? [];
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

        public async Task<IActionResult> OnPostAddAsync()
        {
            DateTime StartDate = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime EndDate = new(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            if (!ModelState.IsValid)
            {
                // Log ou breakpoint aqui para inspecionar ModelState
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                return Page();
            }

            var success = await _contaService.AddContaAsync(Conta);

            if (success)
            {
                // Recarregar a lista de contas após adicionar a nova conta
                Contas = await _contaService.GetContasAsync(StartDate, EndDate);
                return RedirectToPage(); // Redirecionar para atualizar a página
            }

            // Caso a adição não tenha sido bem-sucedida, exibir uma mensagem ou tomar alguma ação
            ModelState.AddModelError(string.Empty, "Não foi possível adicionar a conta.");
            return Page();
        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                // Retorna à página se o modelo estiver inválido
                return Page();
            }

            // Chama o serviço para editar a conta
            var success = await _contaService.EditContaAsync(Conta);

            if (success)
            {
                // Recarrega a lista de contas após a edição
                Contas = await _contaService.GetContasAsync(StartDate, EndDate);
                return RedirectToPage(); // Redireciona para atualizar a página
            }

            // Caso a edição não tenha sido bem-sucedida, exibe uma mensagem de erro
            ModelState.AddModelError(string.Empty, "Não foi possível editar a conta.");
            return Page();
        }
    }
}
