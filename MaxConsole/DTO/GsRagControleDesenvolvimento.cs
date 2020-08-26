using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagControleDesenvolvimento
    {
        public int DsvId { get; set; }
        public int AssId { get; set; }
        public int FunId { get; set; }
        public string DsvDes { get; set; }
        public DateTime? DsvDatiniprev { get; set; }
        public DateTime? DsvDatfimprev { get; set; }
        public string DsvMod { get; set; }
        public int? DsvSit { get; set; }
        public DateTime? DsvDatinireal { get; set; }
        public DateTime? DsvDatfimreal { get; set; }
        public string DsvInfo { get; set; }
        public int? DsvApostila { get; set; }
        public int? DsvHelp { get; set; }
        public int? DsvTeste { get; set; }
        public int? DsvTela { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
