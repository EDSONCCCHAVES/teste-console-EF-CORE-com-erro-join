using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseCfopPrefeituras
    {
        public int Id { get; set; }
        public int PrefeituraId { get; set; }
        public int CfopCodigo { get; set; }
        public string CfopNome { get; set; }
        public string CfopNota { get; set; }
        public int CfopSys { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GtPrefeituras Prefeitura { get; set; }
    }
}
