namespace SistemaLogistica.Entities
{
    public class Rastreamento
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public  decimal Velocidade {  get; set; }
        public DateTime DataHora { get; set; }

    }
}
