using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasBancarias
    {
        public GsContasBancarias()
        {
            GsContasReceberBaixasCheques = new HashSet<GsContasReceberBaixasCheques>();
        }

        public int ConbanId { get; set; }
        public int AssId { get; set; }
        public int? BanId { get; set; }
        public int? EmpId { get; set; }
        public string ConbanDes { get; set; }
        public decimal? ConbanSalini { get; set; }
        public decimal? ConbanSallim { get; set; }
        public string ConbanAge { get; set; }
        public string ConbanDigage { get; set; }
        public string ConbanCon { get; set; }
        public string ConbanDigcon { get; set; }
        public string ConbanCarteiras { get; set; }
        public string ConbanCodced { get; set; }
        public string ConbanDigcodced { get; set; }
        public int? ConbanSegarqmag { get; set; }
        public int? ConbanForarq { get; set; }
        public int? ConbanNosnumini { get; set; }
        public int? ConbanNosnumfim { get; set; }
        public int? ConbanNosnumatu { get; set; }
        public string ConbanLocalpag { get; set; }
        public string ConbanInstpag { get; set; }
        public int? ConbanTipcon { get; set; }
        public string ConbanPatharqrem { get; set; }
        public string ConbanPatharqret { get; set; }
        public string ConbanNomtit { get; set; }
        public int? ConbanPapcob { get; set; }
        public int? ConbanTippes { get; set; }
        public int? ConbanGernosnum { get; set; }
        public int? ConbanSit { get; set; }
        public int? ConbanTipbol { get; set; }
        public decimal? ConbanSalatu { get; set; }
        public int? OpecarId { get; set; }
        public string ConbanNumcar { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string Id26 { get; set; }
        public DateTime? ConbanDatabe { get; set; }
        public string ConbanInstcob { get; set; }
        public string ConbanContrato { get; set; }
        public string ConbanObs { get; set; }
        public int? ConbanRegis { get; set; }
        public int? ConbanRemini { get; set; }
        public double? TarifaAdm { get; set; }
        public double? TarifaIof { get; set; }
        public int? CliforId { get; set; }
        public double? TaxaAdn { get; set; }
        public double? UltTarifaAdm { get; set; }
        public double? UltTarifaIof { get; set; }
        public double? UltTaxaAdn { get; set; }

        public virtual ICollection<GsContasReceberBaixasCheques> GsContasReceberBaixasCheques { get; set; }
    }
}
