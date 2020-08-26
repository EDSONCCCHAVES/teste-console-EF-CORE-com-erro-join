using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosMateriaisItens
    {
        public int EvtmatiteId { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public int? MatId { get; set; }
        public int? EvtmatId { get; set; }
        public DateTime? EvtmatiteDatasaida { get; set; }
        public DateTime? EvtmatiteDataretorno { get; set; }
        public int? EvtmatiteTiposaida { get; set; }
        public int? EvtmatiteTipoentrada { get; set; }
        public int? EvtmatiteIdorigem { get; set; }
        public int? EvtmatiteIddestino { get; set; }
        public string EvtmatiteObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? NfId { get; set; }
        public int? EvtmatiteLancado { get; set; }
        public int? EvtmatiteQtdLancado { get; set; }
    }
}
