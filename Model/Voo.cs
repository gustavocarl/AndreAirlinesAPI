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
        public virtual Aeroporto SiglaDestino { get; set; }
        public virtual Aeroporto SiglaOrigem { get; set; }
        public virtual Aeronave CodigoAeronave { get; set; }
        public DateTime HorarioEmbarque { get; set; }
        public DateTime HorarioDesembarque { get; set; }
        public virtual Passageiro CPF { get; set; }

        #endregion

        #region Sobrescrita

        public override string ToString()
        {
            return $"\nID: {ID} " +
                $"\nDestino: {SiglaDestino.Sigla} " +
                $"\nOrigem: {SiglaOrigem.Sigla} " +
                $"\nCodigo Aeronave: {CodigoAeronave.Codigo} " +
                $"\nHorario Embarque: {HorarioEmbarque.ToString("dd/MM/yyyy").Replace("-", "/")} " +
                $"\nHorario Desembarque: {HorarioDesembarque.ToString("dd/MM/yyyy").Replace("-", "/")} " +
                $"\nCPF: {CPF.CPF}\n";
        }

        #endregion
    }
}