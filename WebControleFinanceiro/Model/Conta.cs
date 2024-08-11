namespace WebControleFinanceiro.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public bool Pago { get; set; }
    }
}
