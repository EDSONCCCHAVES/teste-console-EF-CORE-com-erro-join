using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsBancos
    {
        public GsBancos()
        {
            GsContasReceberBaixasCheques = new HashSet<GsContasReceberBaixasCheques>();
        }

        public int BanId { get; set; }
        public int? AssId { get; set; }
        public string BanNom { get; set; }
        public int? BanCod { get; set; }
        public int? BanDig { get; set; }
        public string BanMasage { get; set; }
        public string BanMascon { get; set; }
        public string BanSite { get; set; }
        public string BanLogofile { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }

        public virtual ICollection<GsContasReceberBaixasCheques> GsContasReceberBaixasCheques { get; set; }
    }
}
