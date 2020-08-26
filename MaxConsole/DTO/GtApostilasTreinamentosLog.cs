using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtApostilasTreinamentosLog
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int AssId { get; set; }
        public int AptId { get; set; }
        public string AplDesc { get; set; }
        public DateTime AplDatacesso { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
    }
}
