using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssistenciaTecnica
    {
        public int AsstecId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? AsstecSit { get; set; }
        public DateTime? AsstecDatsol { get; set; }
        public int? AsstecItens { get; set; }
        public DateTime? AsstecDatcon { get; set; }
        public string AsstecSolicitacao { get; set; }
        public string AsstecConclusao { get; set; }
        public int? EqtserId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string AsstecInfor { get; set; }
    }
}
