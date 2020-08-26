using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoPagamentoForpg
    {
        public int BorpagfpgId { get; set; }
        public int AssId { get; set; }
        public int? BorpagtitId { get; set; }
        public int? BorpagId { get; set; }
        public int? ForpagId { get; set; }
        public int? ConbanId { get; set; }
        public decimal? BorpagfpgValor { get; set; }
        public int? BorpagfpgChqnum { get; set; }
        public DateTime? BorpagfpgData { get; set; }
        public int? BorpagfpgOper { get; set; }
        public string BorpagfpgConta { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
