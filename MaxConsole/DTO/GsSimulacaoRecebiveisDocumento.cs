using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSimulacaoRecebiveisDocumento
    {
        public int SimrecdId { get; set; }
        public int SimrecId { get; set; }
        public int MovbanId { get; set; }
        public int AssId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string ReceberPagar { get; set; }
        public string CartaoCheque { get; set; }
    }
}
