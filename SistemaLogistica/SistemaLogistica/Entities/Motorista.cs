namespace SistemaLogistica.Entities
{
    public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnh { get; set; }
        public int VeiculoId { get; set; } // Veículo associado
    }
}
