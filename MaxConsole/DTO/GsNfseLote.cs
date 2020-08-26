using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfseLote
    {
        public int NfseloteId { get; set; }
        public int AssId { get; set; }
        public int? NfseloteNumero { get; set; }
        public DateTime? NfseloteDataenvio { get; set; }
        public string NfseloteSucesso { get; set; }
        public string NfseloteAssincrono { get; set; }
        public int? NfseloteSituacao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EmpId { get; set; }
        public int NfseloteProtocolo { get; set; }
    }
}
