using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseTagsXml
    {
        public GtNfseTagsXml()
        {
            GtNfseLigacaoCamposTagsXml = new HashSet<GtNfseLigacaoCamposTagsXml>();
        }

        public int Id { get; set; }
        public int ProvedorId { get; set; }
        public string TagDescricao { get; set; }
        public string TagNome { get; set; }
        public int TagFlagUtilizarValorPadrao { get; set; }
        public string TagValorPadrao { get; set; }
        public string TagNomeClasse { get; set; }
        public string TagMetodoClasse { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GtProvedores Provedor { get; set; }
        public virtual ICollection<GtNfseLigacaoCamposTagsXml> GtNfseLigacaoCamposTagsXml { get; set; }
    }
}
