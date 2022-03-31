using System;
using System.ComponentModel.DataAnnotations;

namespace AndreAirlinesAPI.Model
{
    public class Passageiro
    {
        #region Propriedades

        [Key]
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public Endereco IDEndereco { get; set; }

        #endregion
    }
}
