using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAlmoxarifadosHistorico
    {
        public int AmxtransfId { get; set; }
        public int AssId { get; set; }
        public int AmxDestinoId { get; set; }
        public string AmxtransfObs { get; set; }
        public DateTime AmxtransfDatasaida { get; set; }
        public DateTime? AmxtransfDataretorno { get; set; }
        public int FunSaidaId { get; set; }
        public int? FunRetornoId { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
    }
}
