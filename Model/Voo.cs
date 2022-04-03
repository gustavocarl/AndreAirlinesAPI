using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreAirlinesAPI.Model
{
    public class Voo
    {
        #region Propriedades

        [Key]
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("Destino")]
        public virtual Aeroporto Destino { get; set; }
        [JsonProperty("Origem")]
        public virtual Aeroporto Origem { get; set; }
        [JsonProperty("CodigoAeronave")]
        public virtual Aeronave CodigoAeronave { get; set; }
        [JsonProperty("HorarioEmbarque")]
        public DateTime HorarioEmbarque { get; set; }
        [JsonProperty("HorarioDesembarque")]
        public DateTime HorarioDesembarque { get; set; }
        //public virtual Passageiro CPF { get; set; }

        #endregion

        #region Sobrescrita

        public override string ToString()
        {
            return $"\nID: {ID} " +
                $"\nDestino: {Destino.Sigla} " +
                $"\nOrigem: {Origem.Sigla} " +
                $"\nCodigo Aeronave: {CodigoAeronave.Codigo} " +
                $"\nHorario Embarque: {HorarioEmbarque.ToString("dd/MM/yyyy").Replace("-", "/")} " +
                $"\nHorario Desembarque: {HorarioDesembarque.ToString("dd/MM/yyyy").Replace("-", "/")} ";
                //$"\nCPF: {CPF.CPF}\n";
        }

        #endregion
    }
}