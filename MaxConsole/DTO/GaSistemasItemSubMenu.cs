using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaSistemasItemSubMenu
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int SysMenuId { get; set; }
        public int SysSubMenuId { get; set; }
        public int SysItemSubMenuCodigo { get; set; }
        public string SysItemSubMenuObjeto { get; set; }
        public string SysItemSubMenuDesc { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
