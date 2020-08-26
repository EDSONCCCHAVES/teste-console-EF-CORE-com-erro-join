using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMovimentacaoBancaria
    {
        public int MovbanId { get; set; }
        public int AssId { get; set; }
        public int? ConbanId { get; set; }
        public int? MovbanTipo { get; set; }
        public DateTime? MovbanData { get; set; }
        public string MovbanDes { get; set; }
        public decimal? MovbanValor { get; set; }
        public string MovbanObs { get; set; }
        public string MovbanDoc { get; set; }
        public decimal? MovbanSaldo { get; set; }
        public int? MovbanOpe { get; set; }
        public int? CppId { get; set; }
        public int? CrpId { get; set; }
        public int? CattitId { get; set; }
        public int? SubcattitId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? MovbanAdiant { get; set; }
        public int? MovbanPrestcon { get; set; }
        public int? FunId { get; set; }
        public int? MovbanCb { get; set; }
        public DateTime? MovbanCbdata { get; set; }
        public string MovbanCbdoc { get; set; }
        public string MovbanCbdes { get; set; }
        public int? CrbId { get; set; }
        public int? CpbId { get; set; }
        public int? BorpagchqId { get; set; }
        public int? BorrecchqId { get; set; }
    }
}
