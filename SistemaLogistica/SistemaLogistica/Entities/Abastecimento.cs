namespace SistemaLogistica.Entities
{
    public class Abastecimento
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public double Litros { get; set; }
        public DateTime Data { get; set; }
    }
}
