using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoRecebimento
    {
        public int BorrecId { get; set; }
        public int AssId { get; set; }
        public int? BorrecNum { get; set; }
        public int? BorrecSit { get; set; }
        public int? BorrecTit { get; set; }
        public decimal? BorrecValtit { get; set; }
        public decimal? BorrecValrec { get; set; }
        public string BorrecObs { get; set; }
        public DateTime? BorrecDatapr { get; set; }
        public DateTime? BorrecDatcan { get; set; }
        public int? BorrecParnum { get; set; }
        public int? BorrecOrdem { get; set; }
        public string BorrecMotcan { get; set; }
        public int? ConbanId { get; set; }
        public int? UseId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? BorrecPagunico { get; set; }
        public string SysVersaoCad { get; set; }
        public string SysVersaoApr { get; set; }
        public string SysVersaoCan { get; set; }
    }
}
