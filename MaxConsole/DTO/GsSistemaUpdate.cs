using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSistemaUpdate
    {
        public int SysupdId { get; set; }
        public int? AssId { get; set; }
        public string SysupdVersao { get; set; }
        public int? SysupdVersaomaior { get; set; }
        public int? SysupdVersaomenor { get; set; }
        public int? SysupdVersaorelease { get; set; }
        public int? SysupdVersaobuild { get; set; }
        public DateTime? SysupdData { get; set; }
        public string SysupdFile { get; set; }
        public string SysupdUrl { get; set; }
        public int? SysupdTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
