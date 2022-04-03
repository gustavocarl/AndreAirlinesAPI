using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class Passagem
    {
        #region Propriedades

        [Key]
        [JsonProperty("ID")]
        public int Id { get; set; }
        
        [JsonProperty("Passageiro")]
        public Passageiro Passageiro { get; set; }
        
        [JsonProperty("Voo")]
        public Voo Voo { get; set; }

        [JsonProperty("Valor")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
        
        [JsonProperty("Classe")]
        public Classe Classe { get; set; }
        
        [JsonProperty("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        #endregion
    }
}
