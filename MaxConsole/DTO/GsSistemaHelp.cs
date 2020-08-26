using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSistemaHelp
    {
        public int SyshelpId { get; set; }
        public int? AssId { get; set; }
        public string SyshelpMod { get; set; }
        public string SyshelpItem { get; set; }
        public string SyshelpDes { get; set; }
        public string SyshelpInfo { get; set; }
        public int? SyshelpTipo { get; set; }
        public string SyshelpHtml { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
