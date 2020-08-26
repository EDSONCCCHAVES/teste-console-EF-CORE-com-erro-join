using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPaises
    {
        public int PaisId { get; set; }
        public string PaisNome { get; set; }
        public int? EmpId { get; set; }
        public string PaisSgl { get; set; }
        public int? SetId { get; set; }
        public int? PaisSit { get; set; }
        public int? EvtId { get; set; }
        public int? SysInfo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
