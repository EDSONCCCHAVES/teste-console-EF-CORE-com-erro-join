using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociados
    {
        public GsAssociados()
        {
            GsCancelamentosPedidosCompras = new HashSet<GsCancelamentosPedidosCompras>();
            GsContasReceberBaixasCheques = new HashSet<GsContasReceberBaixasCheques>();
            GsFuncionariosCargosNiveis = new HashSet<GsFuncionariosCargosNiveis>();
            GsObservacoesOrcamentos = new HashSet<GsObservacoesOrcamentos>();
            GsOrcamentosObservacoes = new HashSet<GsOrcamentosObservacoes>();
            GsPedidosComprasCancelamentos = new HashSet<GsPedidosComprasCancelamentos>();
            GtNfseConfiguracaoCliente = new HashSet<GtNfseConfiguracaoCliente>();
            GtNfseLigacaoNotaFiscalIntermediarios = new HashSet<GtNfseLigacaoNotaFiscalIntermediarios>();
            GtNotaFiscalLog = new HashSet<GtNotaFiscalLog>();
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
            GtNotaFiscalServicoNfseLog = new HashSet<GtNotaFiscalServicoNfseLog>();
            GtNotaFiscalServicoParcela = new HashSet<GtNotaFiscalServicoParcela>();
        }

        public int AssId { get; set; }
        public string AssNome { get; set; }
        public int? AssSit { get; set; }
        public int? AssRamo { get; set; }
        public int AssTipo { get; set; }
        public string AssEmail { get; set; }
        public int? AssLicenca { get; set; }
        public string AssSite { get; set; }
        public int? AssCorimpcli { get; set; }
        public int? AssOpcserv { get; set; }
        public int? AssServ { get; set; }
        public string AssServHostname { get; set; }
        public string AssServDatabase { get; set; }
        public string AssServUsername { get; set; }
        public string AssServPassword { get; set; }
        public int? AssHd { get; set; }
        public DateTime? AssVctenvctt { get; set; }
        public int? AssCttsit { get; set; }
        public string AssCttdoc { get; set; }
        public DateTime? AssCttdatlib { get; set; }
        public int? CidId { get; set; }
        public int? CliforId { get; set; }
        public int? AtgId { get; set; }
        public int? Sispct1 { get; set; }
        public int? Sispct2 { get; set; }
        public int? Sispct3 { get; set; }
        public int? Sispct4 { get; set; }
        public int? Sispct5 { get; set; }
        public int? Sispct6 { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
        public string AssdcHostname { get; set; }
        public string AssdcDatabase { get; set; }
        public string AssdcUsername { get; set; }
        public string AssdcPassword { get; set; }
        public int? AssmodFolhapag { get; set; }
        public int? AssmodComeletr { get; set; }
        public int? AssFilial { get; set; }
        public int? AssBloqlic { get; set; }
        public int? AssBloqlicnum { get; set; }
        public int? AssFusoHorario { get; set; }
        public int? AssBloqueio { get; set; }
        public int? AssLinha { get; set; }
        public int? AssSublinha { get; set; }
        public int? AssmodNfse { get; set; }
        public int? AssmodNfe { get; set; }
        public byte[] AssLogotipo { get; set; }
        public int? TipoServidor { get; set; }
        public int? EmpId { get; set; }
        public int? Sispct7 { get; set; }
        public int? AssTipoSeguimento { get; set; }
        public int? AssTipfor { get; set; }
        public int? AssmodCerimonial { get; set; }
        public int? AssIniponto { get; set; }
        public string AssPathLogo { get; set; }
        public int AssmodPlanoContasAdic { get; set; }
        public int? AssmodHoraextTecnicoEvt { get; set; }
        public int? AssmodColetorDados { get; set; }
        public int? AssPagaManutencao { get; set; }
        public int? AssPagaHospedagem { get; set; }
        public int? AssPgManutHosped { get; set; }
        public int? AssmodColetorApp { get; set; }
        public int? AssmodEmAprovacao { get; set; }

        public virtual ICollection<GsCancelamentosPedidosCompras> GsCancelamentosPedidosCompras { get; set; }
        public virtual ICollection<GsContasReceberBaixasCheques> GsContasReceberBaixasCheques { get; set; }
        public virtual ICollection<GsFuncionariosCargosNiveis> GsFuncionariosCargosNiveis { get; set; }
        public virtual ICollection<GsObservacoesOrcamentos> GsObservacoesOrcamentos { get; set; }
        public virtual ICollection<GsOrcamentosObservacoes> GsOrcamentosObservacoes { get; set; }
        public virtual ICollection<GsPedidosComprasCancelamentos> GsPedidosComprasCancelamentos { get; set; }
        public virtual ICollection<GtNfseConfiguracaoCliente> GtNfseConfiguracaoCliente { get; set; }
        public virtual ICollection<GtNfseLigacaoNotaFiscalIntermediarios> GtNfseLigacaoNotaFiscalIntermediarios { get; set; }
        public virtual ICollection<GtNotaFiscalLog> GtNotaFiscalLog { get; set; }
        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
        public virtual ICollection<GtNotaFiscalServicoNfseLog> GtNotaFiscalServicoNfseLog { get; set; }
        public virtual ICollection<GtNotaFiscalServicoParcela> GtNotaFiscalServicoParcela { get; set; }
    }
}
