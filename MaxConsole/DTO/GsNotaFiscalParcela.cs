using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalParcela
    {
        public int NfparId { get; set; }
        public int AssId { get; set; }
        public int NfId { get; set; }
        public int? NfparNum { get; set; }
        public decimal? NfparValor { get; set; }
        public int? NfparPrazo { get; set; }
        public DateTime? NfparVecnto { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
