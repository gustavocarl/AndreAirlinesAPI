using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AndreAirlinesAPI.Model
{
    public class Classe
    {
        #region Propriedades
        [Key]
        [JsonProperty("ID")]
        public int Id { get; set; }
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        #endregion
    }
}
