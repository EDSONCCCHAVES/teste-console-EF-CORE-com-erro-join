using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtApostilasTreinamentos
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int? SysMenu1Id { get; set; }
        public int? SysMenu2Id { get; set; }
        public int? SysMenu3Id { get; set; }
        public int? SysMenu4Id { get; set; }
        public string AptNome { get; set; }
        public string AptInfoAdicionais { get; set; }
        public string AptDesc { get; set; }
        public int AptTipoFtp { get; set; }
        public string AptDiretorioFtp { get; set; }
        public int AptFlagSituacao { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
    }
}
