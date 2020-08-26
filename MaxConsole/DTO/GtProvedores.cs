using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtProvedores
    {
        public GtProvedores()
        {
            GtNfseCamposXml = new HashSet<GtNfseCamposXml>();
            GtNfseLigacaoCamposMetodos = new HashSet<GtNfseLigacaoCamposMetodos>();
            GtNfseLigacaoCamposTagsXml = new HashSet<GtNfseLigacaoCamposTagsXml>();
            GtNfseTagsXml = new HashSet<GtNfseTagsXml>();
            GtNfseXmlMetodos = new HashSet<GtNfseXmlMetodos>();
            GtPrefeituras = new HashSet<GtPrefeituras>();
        }

        public int Id { get; set; }
        public string PrvdNome { get; set; }
        public string PrvdVersaoXml { get; set; }
        public string PrvdNamespaceXml { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual ICollection<GtNfseCamposXml> GtNfseCamposXml { get; set; }
        public virtual ICollection<GtNfseLigacaoCamposMetodos> GtNfseLigacaoCamposMetodos { get; set; }
        public virtual ICollection<GtNfseLigacaoCamposTagsXml> GtNfseLigacaoCamposTagsXml { get; set; }
        public virtual ICollection<GtNfseTagsXml> GtNfseTagsXml { get; set; }
        public virtual ICollection<GtNfseXmlMetodos> GtNfseXmlMetodos { get; set; }
        public virtual ICollection<GtPrefeituras> GtPrefeituras { get; set; }
    }
}
