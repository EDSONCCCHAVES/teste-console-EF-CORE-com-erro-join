using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAdiantamentos
    {
        public int AdiId { get; set; }
        public int AssId { get; set; }
        public int? AdiorcId { get; set; }
        public int? AdievtId { get; set; }
        public int? MovbanId { get; set; }
        public int? FunId { get; set; }
        public int? ConbanId { get; set; }
        public int? AdiNum { get; set; }
        public DateTime? AdiData { get; set; }
        public decimal? AdiValor { get; set; }
        public int? AdiSit { get; set; }
        public int? AdiTipo { get; set; }
        public DateTime? AdiDatliq { get; set; }
        public DateTime? AdiDatcan { get; set; }
        public string AdiMotcan { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string AdiObs { get; set; }
        public int? AdiOperacao { get; set; }
        public int? ConbanIdDestino { get; set; }
    }
}
