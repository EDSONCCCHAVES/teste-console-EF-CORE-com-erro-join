using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtVideosTreinamentosLog
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int AssId { get; set; }
        public int VdoId { get; set; }
        public string VtlDesc { get; set; }
        public string VtlTempoAssistido { get; set; }
        public string VtlTempoTotal { get; set; }
        public DateTime VtlDatacesso { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
    }
}
