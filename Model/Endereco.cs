using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AndreAirlinesAPI.Model
{
    public class Endereco
    {
        #region Propriedades
        [Key]
        [JsonProperty("ID")]
        public int ID { get; set; } 
        [JsonProperty("Logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("Bairro")]
        public string Bairro { get; set; }
        [JsonProperty("Localidade")]
        public string Localidade { get; set; }
        [JsonProperty("CEP")]
        public string CEP { get; set; }
        [JsonProperty("uf")]
        public string UF { get; set; }
        [JsonProperty("Complemento")]
        public string Complemento { get; set; }
        [JsonProperty("Numero")]
        public int Numero { get; set; }
        [JsonProperty("Pais")]
        public string Pais { get; set; }

        #endregion
    }
}
