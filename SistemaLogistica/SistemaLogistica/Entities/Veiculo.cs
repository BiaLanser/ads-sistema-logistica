﻿namespace SistemaLogistica.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Status { get; set; } // Disponível, Em Movimento, Em Manutenção
    }
}




