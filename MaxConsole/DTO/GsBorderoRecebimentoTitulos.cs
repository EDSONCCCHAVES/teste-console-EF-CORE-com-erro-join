using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoRecebimentoTitulos
    {
        public int BorrectitId { get; set; }
        public int AssId { get; set; }
        public int? CrpId { get; set; }
        public int? CrbId { get; set; }
        public int? BorrecId { get; set; }
        public decimal? BorrectitValor { get; set; }
        public decimal? BorrectitJuros { get; set; }
        public decimal? BorrectitMulta { get; set; }
        public decimal? BorrectitDesconto { get; set; }
        public decimal? BorrectitTotal { get; set; }
        public string BorrectitObs { get; set; }
        public DateTime? BorrectitDatrec { get; set; }
        public int? ForpagId { get; set; }
        public int? BorrectitBanidchq { get; set; }
        public string BorrectitAgechq { get; set; }
        public string BorrectitConchq { get; set; }
        public string BorrectitNumchq { get; set; }
        public DateTime? BorrectitDatchq { get; set; }
        public string BorrectitInfo { get; set; }
        public int? BorrectitOpe { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AgrsugrecId { get; set; }
        public decimal? BorrectitOdespesas { get; set; }
    }
}
