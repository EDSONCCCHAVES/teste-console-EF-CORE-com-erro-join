using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosRag
    {
        public int EveragId { get; set; }
        public int AssId { get; set; }
        public DateTime? EveragDataini { get; set; }
        public DateTime? EveragDatafim { get; set; }
        public string EveragHora { get; set; }
        public string EveragLocal { get; set; }
        public string EveragTema { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string EveragHorat { get; set; }
        public string EveragInscricao { get; set; }
        public string EveragConteudo { get; set; }
        public string EveragInfo { get; set; }
        public int? EveragStatus { get; set; }
        public int? EveragTipo { get; set; }
        public int? EveragArea { get; set; }
        public DateTime? EveragExibini { get; set; }
        public DateTime? EveragExibfim { get; set; }
        public string EveragDinscricao { get; set; }
        public string EveragDconteudo { get; set; }
        public bool? EveragGs { get; set; }
        public bool? EveragGi { get; set; }
    }
}
