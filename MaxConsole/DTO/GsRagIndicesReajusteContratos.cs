using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagIndicesReajusteContratos
    {
        public int Id { get; set; }
        public string IndNome { get; set; }
        public string IndMesReajuste { get; set; }
        public int IndAnoReajuste { get; set; }
        public double IndValorReajuste { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public int? NumMes { get; set; }
    }
}
