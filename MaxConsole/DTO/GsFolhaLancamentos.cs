using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFolhaLancamentos
    {
        public int FolhalanId { get; set; }
        public int FolhaId { get; set; }
        public int AssId { get; set; }
        public int? VerbfolId { get; set; }
        public string FolhalanDes { get; set; }
        public decimal? FolhalanValor { get; set; }
        public DateTime? FolhalanData { get; set; }
        public int? EvtId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
