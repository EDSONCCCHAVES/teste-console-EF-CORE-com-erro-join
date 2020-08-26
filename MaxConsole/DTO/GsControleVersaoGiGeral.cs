using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsControleVersaoGiGeral
    {
        public int ConverId { get; set; }
        public int AssId { get; set; }
        public int? PrgId { get; set; }
        public string ConverVersao { get; set; }
        public DateTime? ConverData { get; set; }
        public string ConverTitulo { get; set; }
        public string ConverInfo { get; set; }
        public int? ConverMod { get; set; }
        public int? ConverPrioridade { get; set; }
        public string ConverVerpub { get; set; }
        public int? ConverVersit { get; set; }
        public DateTime? ConverDatini { get; set; }
        public int? ConverHorini { get; set; }
        public DateTime? ConverDatfim { get; set; }
        public int? ConverHorfim { get; set; }
        public double? ConverPercqbr { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public int? ConverGravasolicitacao { get; set; }
    }
}
