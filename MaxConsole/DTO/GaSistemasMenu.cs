using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaSistemasMenu
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int SysMenuCodigo { get; set; }
        public string SysMenuObjeto { get; set; }
        public string SysMenuDesc { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
