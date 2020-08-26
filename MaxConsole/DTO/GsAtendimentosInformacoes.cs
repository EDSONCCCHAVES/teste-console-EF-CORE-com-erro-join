using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAtendimentosInformacoes
    {
        public int AteinfId { get; set; }
        public int AssId { get; set; }
        public int? AteId { get; set; }
        public int? RagfaqId { get; set; }
        public int? AteinfInf { get; set; }
        public int? AteinfSol { get; set; }
        public int? AteinfRec { get; set; }
        public string AteinfInfdesc { get; set; }
        public string AteinfSoldesc { get; set; }
        public string AteinfRecdesc { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
