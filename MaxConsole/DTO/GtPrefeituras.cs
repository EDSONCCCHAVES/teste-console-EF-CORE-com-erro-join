using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtPrefeituras
    {
        public GtPrefeituras()
        {
            GtNfseCfopPrefeituras = new HashSet<GtNfseCfopPrefeituras>();
            GtNfseClassificacaoServicos = new HashSet<GtNfseClassificacaoServicos>();
            GtNfseConfiguracao = new HashSet<GtNfseConfiguracao>();
        }

        public int Id { get; set; }
        public int ProvedorId { get; set; }
        public int CidId { get; set; }
        public string PrfNome { get; set; }
        public int PrfCodigo { get; set; }
        public byte[] PrfLogotipo { get; set; }
        public string PrfPastaLogotipo { get; set; }
        public string PrfUf { get; set; }
        public string PrfLote { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GtProvedores Provedor { get; set; }
        public virtual ICollection<GtNfseCfopPrefeituras> GtNfseCfopPrefeituras { get; set; }
        public virtual ICollection<GtNfseClassificacaoServicos> GtNfseClassificacaoServicos { get; set; }
        public virtual ICollection<GtNfseConfiguracao> GtNfseConfiguracao { get; set; }
    }
}
