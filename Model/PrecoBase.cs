using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class PrecoBase
    {
        [Key]
        [JsonProperty("ID")]
        public int Id { get; set; }
        [JsonProperty("Voo")]
        public Voo Voo { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        [JsonProperty("Valor")]
        public decimal Valor { get; set; }
        [JsonProperty("PromocaoPorcentagem")]
        public decimal ValorTotal => (Valor - ((decimal)PromocaoPorcentagem / 100) * Valor);
        public double PromocaoPorcentagem { get; set; }
        [JsonProperty("Classe")]
        public Classe Classe { get; set; }
        [JsonProperty("DataInclusao")]
        public DateTime DataInclusao { get; set; }
    }
}
