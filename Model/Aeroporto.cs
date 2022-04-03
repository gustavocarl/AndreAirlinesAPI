using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class Aeroporto
    {
        #region Propriedades

        [Key]
        [JsonProperty("Sigla")]
        public string Sigla { get; set; }
        [JsonProperty("Nome")]
        public string Nome { get; set; }
        [JsonProperty("Endereco")]
        public virtual Endereco Endereco { get; set; }

        #endregion
    }
}
