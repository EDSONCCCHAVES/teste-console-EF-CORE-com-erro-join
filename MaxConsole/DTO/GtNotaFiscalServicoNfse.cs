using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtNotaFiscalServicoNfse
    {
        public GtNotaFiscalServicoNfse()
        {
            GtNotaFiscalServicoNfseLog = new HashSet<GtNotaFiscalServicoNfseLog>();
            GtNotaFiscalServicoParcela = new HashSet<GtNotaFiscalServicoParcela>();
        }

        public int Id { get; set; }
        public int AssId { get; set; }
        public int CfopId { get; set; }
        public int EmpId { get; set; }
        public int CliforId { get; set; }
        public int ConpagId { get; set; }
        public int PrefeituraId { get; set; }
        public int NfseFlagCfopMunicipal { get; set; }
        public int IdCfopPrefeitura { get; set; }
        public int NfseTiponota { get; set; }
        public int NotserId { get; set; }
        public int NfseatId { get; set; }
        public int NfseClatitId { get; set; }
        public int NfseDesgeId { get; set; }
        public int OrcId { get; set; }
        public int EvtId { get; set; }
        public int NfseNumnota { get; set; }
        public int NfseSit { get; set; }
        public DateTime NfseDatemissao { get; set; }
        public decimal NfseSubtotal { get; set; }
        public decimal NfseBaseiss { get; set; }
        public double NfsePerciss { get; set; }
        public decimal NfseValoriss { get; set; }
        public decimal NfseValortotal { get; set; }
        public decimal NfseValoroutdesp { get; set; }
        public decimal NfseValorserv { get; set; }
        public decimal NfseValordesc { get; set; }
        public string NfseTipolanc { get; set; }
        public int NfseSituacao { get; set; }
        public int? NfseRps { get; set; }
        public int? NfseLote { get; set; }
        public string NfseCodigoVerificacao { get; set; }
        public string NfseTiporecolhimento { get; set; }
        public string NfseOperacao { get; set; }
        public string NfseTributacao { get; set; }
        public double NfseAliquotaPis { get; set; }
        public double NfseAliquotaCofins { get; set; }
        public double NfseAliquotaInss { get; set; }
        public double NfseAliquotaIr { get; set; }
        public double NfseAliquotaCsll { get; set; }
        public double NfseValorPis { get; set; }
        public double NfseValorCofins { get; set; }
        public double NfseValorInss { get; set; }
        public double NfseValorIr { get; set; }
        public double NfseValorCsll { get; set; }
        public string NfseTextolivre { get; set; }
        public string NfseObsexterna { get; set; }
        public string NfseObsinterna { get; set; }
        public string NfseInfoadici { get; set; }
        public DateTime? NfseDatcan { get; set; }
        public string NfseObscanc { get; set; }
        public int NfseOptanteSimplesNacional { get; set; }
        public int NfseIncentivadorCultural { get; set; }
        public double NfseValorOutrasRetencoes { get; set; }
        public double NfseValorDescCondicionado { get; set; }
        public double NfseValorDescIncondicionado { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GsAssociadosEmpresas GsAssociadosEmpresas { get; set; }
        public virtual GsCfop GsCfop { get; set; }
        public virtual GsClassificacaoTitulos GsClassificacaoTitulos { get; set; }
        public virtual GsClientesFornecedores GsClientesFornecedores { get; set; }
        public virtual GsCondicoesPagto GsCondicoesPagto { get; set; }
        public virtual GsNfseAtividade GsNfseAtividade { get; set; }
        public virtual ICollection<GtNotaFiscalServicoNfseLog> GtNotaFiscalServicoNfseLog { get; set; }
        public virtual ICollection<GtNotaFiscalServicoParcela> GtNotaFiscalServicoParcela { get; set; }
    }
}
