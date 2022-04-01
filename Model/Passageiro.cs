﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("EnderecoID")]
        public int EnderecoID { get; set; }
        public virtual Endereco Endereco { get; set; }

        #endregion
    }
}
