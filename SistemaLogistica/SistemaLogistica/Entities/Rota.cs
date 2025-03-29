using SistemaLogistica.Enums;

namespace SistemaLogistica.Entities
{
    public class Rota
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataInicio { get; set; }
        public Double TempoEstimado { get; set; }
        public RotaStatus Status { get; set; } //quais? Finalizada, em andamento, pendente
    }
}
