using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalMateriais
    {
        public int NfMateriaisId { get; set; }
        public int AssId { get; set; }
        public int? SysDel { get; set; }
        public double? NfMateriaisQtd { get; set; }
        public decimal? NfMateriaisValor { get; set; }
        public decimal? NfMateriaisValortotal { get; set; }
        public int? NfId { get; set; }
        public int? MatId { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? NfMateriaisDevolvido { get; set; }
        public int? NfMateriaisQtdDevolvido { get; set; }
        public int? NfIdOrigem { get; set; }
        public int? CfopId { get; set; }
    }
}
