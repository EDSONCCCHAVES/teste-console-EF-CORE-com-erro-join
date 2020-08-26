using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseConfiguracao
    {
        public GtNfseConfiguracao()
        {
            GtNfseConfiguracaoCliente = new HashSet<GtNfseConfiguracaoCliente>();
            GtNfseMetodos = new HashSet<GtNfseMetodos>();
        }

        public int Id { get; set; }
        public int PrefeituraId { get; set; }
        public string CfgDescricao { get; set; }
        public int CfgAmbiente { get; set; }
        public string CfgNomeHost { get; set; }
        public string CfgUsuarioHost { get; set; }
        public string CfgSenhaHost { get; set; }
        public int? CfgPortaHost { get; set; }
        public string CfgPastaArquivoResposta { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public string CfgWsNamespace { get; set; }
        public string CfgWsWsdl { get; set; }
        public string CfgWsService { get; set; }
        public string CfgWsPorta { get; set; }
        public string CfgWsEndereco { get; set; }

        public virtual GtPrefeituras Prefeitura { get; set; }
        public virtual ICollection<GtNfseConfiguracaoCliente> GtNfseConfiguracaoCliente { get; set; }
        public virtual ICollection<GtNfseMetodos> GtNfseMetodos { get; set; }
    }
}
