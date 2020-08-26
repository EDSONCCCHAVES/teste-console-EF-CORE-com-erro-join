using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasReceberBaixas
    {
        public GsContasReceberBaixas()
        {
            GsContasReceberBaixasCheques = new HashSet<GsContasReceberBaixasCheques>();
        }

        public int CrbId { get; set; }
        public int AssId { get; set; }
        public int? CrpId { get; set; }
        public int? ForpagId { get; set; }
        public DateTime? CrpDatvct { get; set; }
        public double? CrpValpagar { get; set; }
        public DateTime? CrbDatbaixa { get; set; }
        public double? CrbValpag { get; set; }
        public double? CrbValbaixa { get; set; }
        public double? CrbValmul { get; set; }
        public double? CrbValjur { get; set; }
        public double? CrbValdes { get; set; }
        public double? CrbValoutdes { get; set; }
        public string CrbObs { get; set; }
        public int? BanId { get; set; }
        public string CrbAgeban { get; set; }
        public string CrbConban { get; set; }
        public string CrbChqban { get; set; }
        public DateTime? CrbChqdatpag { get; set; }
        public int? OpecadId { get; set; }
        public string CrbCartnum { get; set; }
        public int? CrbTipmovban { get; set; }
        public int? CrbEstorno { get; set; }
        public int? ConbanId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? Id26 { get; set; }
        public int? CrbSit { get; set; }
        public int? BorrecId { get; set; }
        public int? CrpUsuarioIdAlt { get; set; }
        public DateTime? CrpDataAlt { get; set; }
        public int? AgepagId { get; set; }
        public string OpcCreDeb { get; set; }
        public string OpcCalcTaxa { get; set; }
        public int? QtdParcCre { get; set; }
        public string CrbChqOpcUniVarios { get; set; }
        public string CrbChqOpcProprioTerceiro { get; set; }
        public string CrbChqNmTerceiro { get; set; }
        public string CrbCpfcnpj { get; set; }
        public int? CrbDuplicataCod { get; set; }
        public int? CrbDuplicataSeq { get; set; }
        public DateTime? CrbDuplicataDatEmissao { get; set; }
        public DateTime? CrbDuplicataDatVencimento { get; set; }
        public string CrbDuplicataSacado { get; set; }
        public int? CppUsuarioIdAlt { get; set; }

        public virtual ICollection<GsContasReceberBaixasCheques> GsContasReceberBaixasCheques { get; set; }
    }
}
