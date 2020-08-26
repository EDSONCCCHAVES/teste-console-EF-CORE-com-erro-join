using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalConfig
    {
        public int NfcId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public int? NotserId { get; set; }
        public int? NfcCod { get; set; }
        public int? NfcOrd { get; set; }
        public int? NfcCol { get; set; }
        public int? NfcTam { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
