
using WebControleFinanceiro.Model;

namespace WebAppControleFinanceiro.Services
{
    public class ContaService
    {
        private readonly HttpClient _httpClient;

        public ContaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Conta>> GetContasAsync(DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            var response = await _httpClient.GetAsync("http://localhost:5235/api/Conta");
            response.EnsureSuccessStatusCode();

            var contas = await response.Content.ReadFromJsonAsync<List<Conta>>();

            // Garantir que contas não seja null
            if (contas == null)
            {
                return [];
            }

            // Filtrar contas por intervalo de datas, se fornecido
            if (dataInicio.HasValue && dataFim.HasValue)
            {
                contas = contas
                    .Where(c => c.DataVencimento.Date >= dataInicio.Value.Date && c.DataVencimento.Date <= dataFim.Value.Date)
                    .OrderBy(c => c.Id)
                    .ToList();
            }

            return contas;
        }

        public async Task<bool> DeleteContaAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"http://localhost:5235/api/Conta/{id}");

            // Retornar true se a operação for bem-sucedida, false caso contrário
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> AddContaAsync(Conta novaConta)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5235/api/Conta", novaConta);
            return response.IsSuccessStatusCode;
        }
    }
}
