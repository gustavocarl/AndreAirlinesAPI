using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class Voo
    {
        #region Propriedades

        [Key]
        public int ID { get; set; }
        [ForeignKey("Sigla")]
        public string SiglaDestino { get; set; }
        public virtual Aeroporto DestinoSigla { get; set; }
        [ForeignKey("Sigla")]
        public string SiglaOrigem { get; set; }
        public virtual Aeroporto OrigemSigla { get; set; }
        [ForeignKey("Codigo")]
        public string Codigo { get; set; }
        public virtual Aeronave CodigoAeronave { get; set; }
        public DateTime HorarioEmbarque { get; set; }
        public DateTime HorarioDesembarque { get; set; }
        [ForeignKey("CPF")]
        public string CPF { get; set; }
        public virtual Passageiro CPFPassageiro { get; set; }
        
        #endregion
    }
}