using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfseLoteErro
    {
        public int NfseloteerroId { get; set; }
        public int AssId { get; set; }
        public int? NfseloteId { get; set; }
        public int? NfseloteerroCodigo { get; set; }
        public string NfseloteerroDescricao { get; set; }
        public string NfseloteerroProcedimento { get; set; }
        public int? NfNfseRps { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
