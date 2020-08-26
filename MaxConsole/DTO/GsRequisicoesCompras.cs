using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRequisicoesCompras
    {
        public int ReqcomId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? ReqcomNumped { get; set; }
        public DateTime? ReqcomData { get; set; }
        public DateTime? ReqcomDataprov { get; set; }
        public DateTime? ReqcomDatcanc { get; set; }
        public string ReqcomMotcan { get; set; }
        public int? ReqcomItem { get; set; }
        public int? ReqcomQtd { get; set; }
        public string ReqcomObs { get; set; }
        public int? ReqcomSit { get; set; }
        public int? ReqcomSoltip { get; set; }
        public string ReqcomSoldes { get; set; }
        public int? ReqcomSolqtd { get; set; }
        public string ReqcomSolobs { get; set; }
        public int? ReqcomSolsit { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? ReqcomUsecanId { get; set; }
        public int? ReqcomPaiId { get; set; }
        public int? ReqcomRenovacao { get; set; }
    }
}
