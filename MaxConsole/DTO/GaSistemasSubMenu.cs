using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaSistemasSubMenu
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int SysMenuId { get; set; }
        public int SysSubMenuCodigo { get; set; }
        public string SysSubMenuObjeto { get; set; }
        public string SysSubMenuDesc { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
