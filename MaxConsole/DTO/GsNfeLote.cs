using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNfeLote
    {
        public int NfeloteId { get; set; }
        public int? EmpId { get; set; }
        public int? AssId { get; set; }
        public int? NotserId { get; set; }
        public int? NfeloteNumero { get; set; }
        public DateTime? NfeloteDataenvio { get; set; }
        public string NfeloteSucesso { get; set; }
        public string NfeloteAssincrono { get; set; }
        public int? NfeloteSituacao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
