using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class Aeroporto
    {
        #region Propriedades

        [Key]
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }

        #endregion
    }
}
