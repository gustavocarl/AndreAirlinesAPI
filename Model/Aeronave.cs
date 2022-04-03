using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AndreAirlinesAPI.Model
{
    public class Aeronave
    {
        #region Propriedades

        [Key]
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Capacidade")]
        public int Capacidade { get; set; }

        #endregion
    }
}