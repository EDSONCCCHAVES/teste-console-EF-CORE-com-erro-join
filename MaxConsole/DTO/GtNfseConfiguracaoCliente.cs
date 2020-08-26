using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNfseConfiguracaoCliente
    {
        public GtNfseConfiguracaoCliente()
        {
            GtNfseLayout = new HashSet<GtNfseLayout>();
        }

        public int Id { get; set; }
        public int ConfiguracaoId { get; set; }
        public int AssId { get; set; }
        public int EmpId { get; set; }
        public string CfgcDescricao { get; set; }
        public string CfgcSerieCertificado { get; set; }
        public string CfgcCaminhoCertificado { get; set; }
        public string CfgcSenhaCertificado { get; set; }
        public string CfgcServidorSmtp { get; set; }
        public int CfgcPortaSmtp { get; set; }
        public string CfgcUsuarioSmtp { get; set; }
        public string CfgcSenhaSmtp { get; set; }
        public string CfgcAssuntoEmail { get; set; }
        public short? CfgcFlagSslEmail { get; set; }
        public string CfgcMensagemEmail { get; set; }
        public string CfgcRemetenteEmail { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GtNfseConfiguracao Configuracao { get; set; }
        public virtual GsAssociadosEmpresas GsAssociadosEmpresas { get; set; }
        public virtual ICollection<GtNfseLayout> GtNfseLayout { get; set; }
    }
}
