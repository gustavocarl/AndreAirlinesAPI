using System.ComponentModel.DataAnnotations;

namespace AndreAirlinesAPI.Model
{
    public class Aeronave
    {
        #region Propriedades

        [Key]
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }

        #endregion
    }
}