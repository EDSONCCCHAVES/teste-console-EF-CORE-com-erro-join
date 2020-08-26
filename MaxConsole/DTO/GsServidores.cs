using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsServidores
    {
        public int ServId { get; set; }
        public int AssId { get; set; }
        public string ServName { get; set; }
        public string ServIp { get; set; }
        public string ServUser { get; set; }
        public string ServPass { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
