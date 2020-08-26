using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCargosNiveis
    {
        public int CargnivId { get; set; }
        public int AssId { get; set; }
        public int? CarfunId { get; set; }
        public string CargnivDes { get; set; }
        public int? CargnivTipsal { get; set; }
        public decimal? CargnivSalbase { get; set; }
        public double? CargnivPercom { get; set; }
        public decimal? CargnivCotmin { get; set; }
        public decimal? CargnivPontoobj { get; set; }
        public decimal? CargnivValdir { get; set; }
        public decimal? CargnivValevt { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CargnivHorasTrab { get; set; }
    }
}
