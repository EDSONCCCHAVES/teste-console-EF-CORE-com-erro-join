using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalSeries
    {
        public int NotserId { get; set; }
        public int AssId { get; set; }
        public int EmpId { get; set; }
        public string NotserDes { get; set; }
        public int? NotserNum { get; set; }
        public string NotserObs { get; set; }
        public string NotserPorta { get; set; }
        public int? NotserTippre { get; set; }
        public int? DrvimpId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CfopId { get; set; }
        public int? ServId { get; set; }
        public string NotserTipo { get; set; }
        public int? NotserLote { get; set; }
    }
}
