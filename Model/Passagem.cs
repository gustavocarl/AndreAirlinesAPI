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
        [JsonProperty("Valor")]
        [Column(TypeName = "decimal(10,2)")]
        public PrecoBase PrecoBase { get; set; } //Traz Classe, ValorPassagem, Origem e Destino
        [JsonProperty("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        #endregion
    }
}
