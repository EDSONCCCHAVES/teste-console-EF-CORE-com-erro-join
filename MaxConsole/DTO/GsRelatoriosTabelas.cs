using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRelatoriosTabelas
    {
        public int ReltabId { get; set; }
        public int? RelId { get; set; }
        public int? AssId { get; set; }
        public string ReltabTablename { get; set; }
        public int? ReltabFormtop { get; set; }
        public int? ReltabFormleft { get; set; }
        public int? ReltabFormwidth { get; set; }
        public int? ReltabFormheight { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
