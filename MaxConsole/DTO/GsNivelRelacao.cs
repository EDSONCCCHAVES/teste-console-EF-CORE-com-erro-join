using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNivelRelacao
    {
        public int NirelId { get; set; }
        public int AssId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? NirelAtivo { get; set; }
        public string NirelDes { get; set; }
        public string NirelEtapa { get; set; }
        public int? NirelPosicao { get; set; }
        public int? NirelOrc { get; set; }
        public int? AssempsetId { get; set; }
        public int? StiId { get; set; }
        public int? FsiId { get; set; }

        public virtual GaFasesImplantacao Fsi { get; set; }
        public virtual GaSetoresImplantacao Sti { get; set; }
    }
}
