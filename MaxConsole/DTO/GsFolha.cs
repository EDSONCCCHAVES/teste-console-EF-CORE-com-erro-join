using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFolha
    {
        public int FolhaId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public DateTime? FolhaPagto { get; set; }
        public DateTime? FolhaComp { get; set; }
        public int? FolhaTipo { get; set; }
        public string FolhaObs { get; set; }
        public int? CppId { get; set; }
        public double? FolhaTotcre { get; set; }
        public double? FolhaTotdeb { get; set; }
        public double? FolhaTotger { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
