using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaSistemas
    {
        public int Id { get; set; }
        public int SysCodigo { get; set; }
        public string SysObjeto { get; set; }
        public string SysDescReduzida { get; set; }
        public string SysDescCompleta { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
