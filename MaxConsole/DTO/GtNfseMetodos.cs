using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseMetodos
    {
        public GtNfseMetodos()
        {
            GtNfseLigacaoCamposMetodos = new HashSet<GtNfseLigacaoCamposMetodos>();
            GtNfseXmlMetodos = new HashSet<GtNfseXmlMetodos>();
        }

        public int Id { get; set; }
        public int ConfiguracaoNfseId { get; set; }
        public string MtdNome { get; set; }
        public string MtdDescricao { get; set; }
        public int? MtdTipoRetorno { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public string MtdWsNamespace { get; set; }
        public string MtdWsWsdl { get; set; }
        public string MtdWsService { get; set; }
        public string MtdWsPorta { get; set; }
        public string MtdWsEndereco { get; set; }

        public virtual GtNfseConfiguracao ConfiguracaoNfse { get; set; }
        public virtual ICollection<GtNfseLigacaoCamposMetodos> GtNfseLigacaoCamposMetodos { get; set; }
        public virtual ICollection<GtNfseXmlMetodos> GtNfseXmlMetodos { get; set; }
    }
}
