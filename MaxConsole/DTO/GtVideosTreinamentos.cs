using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtVideosTreinamentos
    {
        public int Id { get; set; }
        public int SysId { get; set; }
        public int? SysMenu1Id { get; set; }
        public int? SysMenu2Id { get; set; }
        public int? SysMenu3Id { get; set; }
        public int? SysMenu4Id { get; set; }
        public int VdoFlagNivelDiretivo { get; set; }
        public int VdoFlagNivelGerencial { get; set; }
        public int VdoFlagNivelOperacional { get; set; }
        public string VdoNome { get; set; }
        public string VdoInfoAdicionais { get; set; }
        public string VdoDesc { get; set; }
        public int VdoTipoFtp { get; set; }
        public string VdoDiretorioFtp { get; set; }
        public int VdoFlagSituacao { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
    }
}
