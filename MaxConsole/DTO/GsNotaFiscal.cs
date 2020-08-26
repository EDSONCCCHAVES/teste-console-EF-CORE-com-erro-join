using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscal
    {
        public GsNotaFiscal()
        {
            GtNotaFiscalLog = new HashSet<GtNotaFiscalLog>();
        }

        public int NfId { get; set; }
        public int AssId { get; set; }
        public int? CfopId { get; set; }
        public int? NotserId { get; set; }
        public int? EmpId { get; set; }
        public int? CliforId { get; set; }
        public int? OrcId { get; set; }
        public int? EvtId { get; set; }
        public int? NfNumnota { get; set; }
        public DateTime? NfDatemissao { get; set; }
        public DateTime? NfDatentrada { get; set; }
        public DateTime? NfDatsaida { get; set; }
        public int? NfImpprod { get; set; }
        public string NfProdcodigo { get; set; }
        public string NfProddescricao { get; set; }
        public int? NfProdquantidade { get; set; }
        public decimal? NfProdvalorunitario { get; set; }
        public string NfObsexterna { get; set; }
        public string NfObsinterna { get; set; }
        public string NfInfoadici { get; set; }
        public int? NfSit { get; set; }
        public decimal? NfSubtotal { get; set; }
        public decimal? NfValorfrete { get; set; }
        public string NfBaseiss { get; set; }
        public double? NfPerciss { get; set; }
        public decimal? NfValoriss { get; set; }
        public decimal? NfBaseicms { get; set; }
        public double? NfPericms { get; set; }
        public decimal? NfValoricms { get; set; }
        public decimal? NfBaseicmsst { get; set; }
        public double? NfPericmsst { get; set; }
        public decimal? NfValoicmsst { get; set; }
        public decimal? NfValortotal { get; set; }
        public decimal? NfValorseguro { get; set; }
        public decimal? NfValoroutdesp { get; set; }
        public decimal? NfValorserv { get; set; }
        public decimal? NfValordesc { get; set; }
        public double? NfVolqtd { get; set; }
        public string NfVolesp { get; set; }
        public string NfVolmarca { get; set; }
        public int? NfVolnum { get; set; }
        public double? NfVolpesoliq { get; set; }
        public double? NfVolpesobruto { get; set; }
        public int? NfPar1 { get; set; }
        public DateTime? NfVct1 { get; set; }
        public double? NfValpar1 { get; set; }
        public int? NfPar2 { get; set; }
        public DateTime? NfVct2 { get; set; }
        public double? NfValpar2 { get; set; }
        public DateTime? NfDatcan { get; set; }
        public int? ConpagId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? SysDatalt { get; set; }
        public int? TranspId { get; set; }
        public string TranspNomemot { get; set; }
        public string TranspVia { get; set; }
        public int? NfReleqt { get; set; }
        public string NfTextolivre { get; set; }
        public int? NfTipoeqt { get; set; }
        public string NfObscanc { get; set; }
        public int? NfTipotransp { get; set; }
        public int? NfOperacao { get; set; }
        public int? NfFrete { get; set; }
        public string TranspUfplaca { get; set; }
        public string TranspCpfcnpj { get; set; }
        public string TranspRginest { get; set; }
        public string TranspMunicipio { get; set; }
        public string TranspUf { get; set; }
        public string TranspEnd { get; set; }
        public string TranspPlaca { get; set; }
        public int? CrpId { get; set; }
        public int? NfTotpaginas { get; set; }
        public string NfTipolanc { get; set; }
        public int? NfNfseSituacao { get; set; }
        public int? NfNfseRps { get; set; }
        public int? NfNfseLote { get; set; }
        public string NfNfseCodigoVerificacao { get; set; }
        public int? NfseatId { get; set; }
        public string NfseTiporecolhimento { get; set; }
        public string NfseOperacao { get; set; }
        public string NfseTributacao { get; set; }
        public double? NfAliquotaPis { get; set; }
        public double? NfAliquotaCofins { get; set; }
        public double? NfAliquotaInss { get; set; }
        public double? NfAliquotaIr { get; set; }
        public double? NfAliquotaCsll { get; set; }
        public double? NfValorPis { get; set; }
        public double? NfValorCofins { get; set; }
        public double? NfValorInss { get; set; }
        public double? NfValorIr { get; set; }
        public double? NfValorCsll { get; set; }
        public int? NfeloteId { get; set; }
        public int? NfNfeSituacao { get; set; }
        public int? CobnfeId { get; set; }
        public int? NfClatitId { get; set; }
        public int? NfdesgeId { get; set; }
        public int? NfGravaenderecoentrega { get; set; }
        public int? NfFinalidadeEmissao { get; set; }
        public int? NfConsumidorFinal { get; set; }
        public int? NfDestinoOperacao { get; set; }
        public int? NfTipoAtendimento { get; set; }
        public string NfChavenfeFinalidadeEmissao { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public int? NfLocalentregaCodmunicipio { get; set; }
        public string NfLocalEmbarque { get; set; }
        public string NfUfEmbarque { get; set; }
        public string NfLocalExportacao { get; set; }
        public string NfUfPaisSaida { get; set; }
        public string NfLocalDespacho { get; set; }
        public byte[] NfAuditoria { get; set; }
        public int? NfTipo { get; set; }
        public int? NfTipofatloc { get; set; }
        public int? Cnf { get; set; }
        public int? NfFlagvctsfatloc { get; set; }
        public string NfVctsfatloc { get; set; }

        public virtual ICollection<GtNotaFiscalLog> GtNotaFiscalLog { get; set; }
    }
}
