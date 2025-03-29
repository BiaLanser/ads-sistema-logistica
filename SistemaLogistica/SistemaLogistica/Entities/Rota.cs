﻿namespace SistemaLogistica.Entities
{
    public class Rota
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataHoraInicio { get; set; }
    }
}
