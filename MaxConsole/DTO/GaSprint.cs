using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaSprint
    {
        public int Id { get; set; }
        public int PrjId { get; set; }
        public string SptNome { get; set; }
        public DateTime SptDatini { get; set; }
        public DateTime SptDatfin { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public int? SptSit { get; set; }
        public int? SptQtdsol { get; set; }
    }
}
