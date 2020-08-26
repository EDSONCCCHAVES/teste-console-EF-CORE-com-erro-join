using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalServico
    {
        public int NfServicoId { get; set; }
        public int AssId { get; set; }
        public int? ServId { get; set; }
        public double? NfServicoQtd { get; set; }
        public decimal? NfServicoValor { get; set; }
        public decimal? NfServicoTotal { get; set; }
        public int? NfId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int NfsId { get; set; }
        public double? NfServValOutRetencoes { get; set; }
        public double? NfServValDescCondic { get; set; }
        public double? NfServValDescIncondic { get; set; }
        public int PrefeituraId { get; set; }
        public int ClassServId { get; set; }
    }
}
