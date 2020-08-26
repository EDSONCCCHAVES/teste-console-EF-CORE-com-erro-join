using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSimulacaoRecebiveis
    {
        public int SimrecId { get; set; }
        public int AssId { get; set; }
        public DateTime? SimrecDatSimulacao { get; set; }
        public double? SimrecTotAdiantamento { get; set; }
        public double? SimrecTotIof { get; set; }
        public double? SimrecTotAdm { get; set; }
        public double? SimrecTotBruto { get; set; }
        public double? SimrecTotLiquido { get; set; }
        public double? SimrecSitSimulacao { get; set; }
        public DateTime? SimrecDatUltimoRecalculo { get; set; }
        public int? SimrecUseId { get; set; }
        public string SimrecObsSimulacao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string ReceberPagar { get; set; }
        public string CartaoCheque { get; set; }
        public int? ConbanId { get; set; }
        public DateTime? DataAntecipacao { get; set; }
        public int? AgepagId { get; set; }
        public int? AgeopeId { get; set; }
    }
}
