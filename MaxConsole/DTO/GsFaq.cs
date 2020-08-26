using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFaq
    {
        public int FaqId { get; set; }
        public int AssId { get; set; }
        public string FaqAss { get; set; }
        public string FaqInfo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
