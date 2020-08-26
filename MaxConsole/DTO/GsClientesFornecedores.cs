using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsClientesFornecedores
    {
        public GsClientesFornecedores()
        {
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
        }

        public int CliforId { get; set; }
        public int AssId { get; set; }
        public string CliforNome { get; set; }
        public int? CliforTipocad { get; set; }
        public string CliforRs { get; set; }
        public string CliforCpfcnpj { get; set; }
        public string CliforRgie { get; set; }
        public int? CliforTipopes { get; set; }
        public int? CliforSit { get; set; }
        public string CliforDdd1 { get; set; }
        public string CliforTel1 { get; set; }
        public string CliforDdd2 { get; set; }
        public string CliforTel2 { get; set; }
        public string CliforNextel { get; set; }
        public int? CliforCodtra { get; set; }
        public string CliforFax { get; set; }
        public string CliforContato { get; set; }
        public string CliforSite { get; set; }
        public string CliforEmail { get; set; }
        public DateTime? CliforDatnas { get; set; }
        public int? CliforEstciv { get; set; }
        public int? CliforSexo { get; set; }
        public int? CliforUltven { get; set; }
        public int? CliforEndcobtip { get; set; }
        public int? CliforEndenttip { get; set; }
        public int? CliforMalaemail { get; set; }
        public int? CliforMalacor { get; set; }
        public int? CliforInfped { get; set; }
        public int? CliforendId { get; set; }
        public int? Cliforend2Id { get; set; }
        public int? Cliforend3Id { get; set; }
        public int? VenId { get; set; }
        public int? ClifororiId { get; set; }
        public int? CliforcobId { get; set; }
        public int? FunId { get; set; }
        public int? RtvId { get; set; }
        public int? GrpcliId { get; set; }
        public string CliforIm { get; set; }
        public int? CliforProspect { get; set; }
        public string CliforObs { get; set; }
        public DateTime? CliforUltimoate { get; set; }
        public int? CliforRestfin { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? Id26 { get; set; }
        public int? CliforFunid { get; set; }
        public string LogUsuario { get; set; }
        public DateTime? LogData { get; set; }
        public string LogIpnum { get; set; }
        public string CliforNumeroContrato { get; set; }
        public DateTime? CliforDataContrato { get; set; }
        public string CliforNomeemp { get; set; }
        public string CliforIccontato { get; set; }
        public string CliforIcfone1 { get; set; }
        public string CliforIcfone2 { get; set; }
        public string CliforIcemail { get; set; }
        public string CliforIcsite { get; set; }
        public string CliforSuframa { get; set; }
        public string CliforEmailnfe { get; set; }
        public int? CliforAss { get; set; }
        public int? CliforRelfor { get; set; }
        public int? CliforContribuinteIcms { get; set; }
        public int CliforExtrangeiro { get; set; }

        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
    }
}
