using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseCamposXml
    {
        public GtNfseCamposXml()
        {
            GtNfseLigacaoCamposMetodos = new HashSet<GtNfseLigacaoCamposMetodos>();
            GtNfseLigacaoCamposTagsXml = new HashSet<GtNfseLigacaoCamposTagsXml>();
        }

        public int Id { get; set; }
        public int ProvedorId { get; set; }
        public string CmpDescricao { get; set; }
        public string CmpNomeCampo { get; set; }
        public int CmpTipoCampo { get; set; }
        public int CmpFlagUtilizarValorPadrao { get; set; }
        public string CmpValorPadrao { get; set; }
        public string CmpNomeClasse { get; set; }
        public string CmpMetodoClasse { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GtProvedores Provedor { get; set; }
        public virtual ICollection<GtNfseLigacaoCamposMetodos> GtNfseLigacaoCamposMetodos { get; set; }
        public virtual ICollection<GtNfseLigacaoCamposTagsXml> GtNfseLigacaoCamposTagsXml { get; set; }
    }
}
