using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosMateriais
    {
        public int OrcmatId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public int? MatId { get; set; }
        public decimal? OrcmatPreco { get; set; }
        public int? OrcmatQtd { get; set; }
        public decimal? OrcmatTotal { get; set; }
        public int? OrcmatAgr { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OrcmatView { get; set; }
        public int? NfId { get; set; }
        public int? OrcmatLancado { get; set; }
        public int? OrcmatQtdLancado { get; set; }
        public int? OrcestiteId { get; set; }
    }
}
