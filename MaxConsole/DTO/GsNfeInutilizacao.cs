using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfeInutilizacao
    {
        public int NfeinuId { get; set; }
        public int? AssId { get; set; }
        public int? UseId { get; set; }
        public int? EmpId { get; set; }
        public int? NotserId { get; set; }
        public int? NfeinuNfInicial { get; set; }
        public int? NfeinuNfFinal { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
