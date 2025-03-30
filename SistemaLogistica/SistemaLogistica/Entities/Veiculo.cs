using SistemaLogistica.Enums;

namespace SistemaLogistica.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public int MotoristaId { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public VeiculoStatus Status { get; set; } // Disponível, Em Movimento, Em Manutenção
    }
}




