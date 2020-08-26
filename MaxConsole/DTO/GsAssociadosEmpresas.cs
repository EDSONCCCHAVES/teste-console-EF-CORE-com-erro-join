using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosEmpresas
    {
        public GsAssociadosEmpresas()
        {
            GtNfseConfiguracaoCliente = new HashSet<GtNfseConfiguracaoCliente>();
            GtNfseLigacaoNotaFiscalIntermediarios = new HashSet<GtNfseLigacaoNotaFiscalIntermediarios>();
            GtNotaFiscalServicoNfse = new HashSet<GtNotaFiscalServicoNfse>();
        }

        public int EmpId { get; set; }
        public int AssId { get; set; }
        public string EmpNome { get; set; }
        public int? EmpTippercorc { get; set; }
        public double? EmpPercsemanal { get; set; }
        public double? EmpPercmensal { get; set; }
        public string EmpEnddes { get; set; }
        public string EmpEndnum { get; set; }
        public string EmpEndcpl { get; set; }
        public string EmpEndcep { get; set; }
        public string EmpEndbai { get; set; }
        public int? CidId { get; set; }
        public string EmpCnpj { get; set; }
        public string EmpIe { get; set; }
        public string EmpIm { get; set; }
        public string EmpDdd1 { get; set; }
        public string EmpDdd2 { get; set; }
        public string EmpTel1 { get; set; }
        public string EmpTel2 { get; set; }
        public string EmpEmail { get; set; }
        public string EmpContato { get; set; }
        public int? EmpSit { get; set; }
        public double? EmpPeriss { get; set; }
        public double? EmpPerdespfixa { get; set; }
        public string EmpDocorc { get; set; }
        public string EmpDoccon { get; set; }
        public string EmpSite { get; set; }
        public int? EmpNumcon { get; set; }
        public int? EmpNumavideb { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string EmpImglogo { get; set; }
        public int? EmpPadrao { get; set; }
        public string EmpLegavideb { get; set; }
        public string EmpDuplicata { get; set; }
        public int? ConbanId { get; set; }
        public string EmpNomeFantasia { get; set; }
        public string EmpNomeResponsavel { get; set; }
        public string EmpRgResponsavel { get; set; }
        public double? EmpPerjuros { get; set; }
        public double? EmpPermulta { get; set; }
        public byte[] EmpLogotipo { get; set; }
        public double? EmpPerencsalario { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public string EmpTel3 { get; set; }

        public virtual ICollection<GtNfseConfiguracaoCliente> GtNfseConfiguracaoCliente { get; set; }
        public virtual ICollection<GtNfseLigacaoNotaFiscalIntermediarios> GtNfseLigacaoNotaFiscalIntermediarios { get; set; }
        public virtual ICollection<GtNotaFiscalServicoNfse> GtNotaFiscalServicoNfse { get; set; }
    }
}
