using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCotasvendasFuncionarios
    {
        public int CotvenfunId { get; set; }
        public int AssId { get; set; }
        public int CotvenId { get; set; }
        public int? FunId { get; set; }
        public double? CotvenfunPercmet { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public double? CotvenfunMeta { get; set; }
    }
}
