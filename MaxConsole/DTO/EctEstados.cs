using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class EctEstados
    {
        public int UfeId { get; set; }
        public string UfeSg { get; set; }
        public string UfeNo { get; set; }
        public string UfeRad1Ini { get; set; }
        public string UfeSuf1Ini { get; set; }
        public string UfeRad1Fim { get; set; }
        public int? PaisId { get; set; }
        public string UfeSuf1Fim { get; set; }
        public string UfeRad2Ini { get; set; }
        public string UfeSuf2Ini { get; set; }
        public string UfeRad2Fim { get; set; }
        public string UfeSuf2Fim { get; set; }
        public int? UfeSit { get; set; }
        public string UfeLinksintegra { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
