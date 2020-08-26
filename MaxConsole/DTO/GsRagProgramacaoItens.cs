using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagProgramacaoItens
    {
        public int DesenitemId { get; set; }
        public int DesenId { get; set; }
        public int? AssId { get; set; }
        public string DesenitemDes { get; set; }
        public string DesenitemInfo { get; set; }
        public int? DesenitemTempoest { get; set; }
        public int? DesenitemTempoatu { get; set; }
        public int? DesenitemSit { get; set; }
        public int? DesenitemOrder { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
