using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBorderoPagamento
    {
        public int BorpagId { get; set; }
        public int AssId { get; set; }
        public int? BorpagNum { get; set; }
        public int? BorpagSit { get; set; }
        public int? BorpagTit { get; set; }
        public decimal? BorpagValtit { get; set; }
        public decimal? BorpagValpag { get; set; }
        public string BorpagObs { get; set; }
        public DateTime? BorpagDatapr { get; set; }
        public DateTime? BorpagDatcan { get; set; }
        public int? BorpagParnum { get; set; }
        public int? BorpagOrdem { get; set; }
        public string BorpagMotcan { get; set; }
        public int? ConbanId { get; set; }
        public int? UseId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? BorpagPagunico { get; set; }
        public string SysVersaoCad { get; set; }
        public string SysVersaoApr { get; set; }
        public string SysVersaoCan { get; set; }
    }
}
