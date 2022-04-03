using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class Passageiro
    {
        #region Propriedades

        [Key]
        [JsonProperty("CPF")]
        public string CPF { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Telefone")]
        public string Telefone { get; set; }

        [JsonProperty("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Endereco")]
        public Endereco Endereco { get; set; }

        #endregion
    }
}
