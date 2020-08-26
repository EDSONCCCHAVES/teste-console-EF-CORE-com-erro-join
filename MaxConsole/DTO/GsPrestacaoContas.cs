using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPrestacaoContas
    {
        public int PresconId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? AdievtId { get; set; }
        public int? OrcId { get; set; }
        public int? MovbanId { get; set; }
        public int? FunId { get; set; }
        public int? CrtId { get; set; }
        public int? CptId { get; set; }
        public int? PreconNumprecon { get; set; }
        public DateTime? PreconData { get; set; }
        public int? PreconTipo { get; set; }
        public decimal? PreconValor { get; set; }
        public int? PreconSit { get; set; }
        public int? PreconVale { get; set; }
        public int? PreconRec { get; set; }
        public decimal? PreconValdin { get; set; }
        public decimal? PreconValorpago { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
