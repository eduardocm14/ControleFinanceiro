namespace WebAPIControleFinanceiroCore.Model
{
    public class ContratoAluguel
    {
        public int Id { get; set; }
        public required string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public required string NomeProprietario { get; set; }
        public required string NomeLocatario { get; set; }

        // Para armazenar o caminho do arquivo ou o próprio arquivo
        public string? ContratoPath { get; set; }

        // Propriedade para upload de arquivo (pode ser uma imagem ou PDF)
        //public IFormFile? ContratoUpload { get; set; }
    }
}
