namespace SistemaLogistica.Entities
{
    public class Abastecimento
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public decimal LitrosAbastecidos { get; set; }
        public decimal ValorAbastecido { get; set; }
        public DateTime Data { get; set; }
    }
}
