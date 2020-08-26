using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasPagarBaixas
    {
        public int CpbId { get; set; }
        public int AssId { get; set; }
        public int? CppId { get; set; }
        public int? ForpagId { get; set; }
        public int? BanId { get; set; }
        public int? OpecadId { get; set; }
        public int? ConbanId { get; set; }
        public int? BorpagId { get; set; }
        public DateTime? CpbDatbaixa { get; set; }
        public double? CpbValpag { get; set; }
        public double? CpbValbaixa { get; set; }
        public double? CpbValmul { get; set; }
        public double? CpbValjur { get; set; }
        public double? CpbValdes { get; set; }
        public double? CpbValoutdes { get; set; }
        public string CpbObs { get; set; }
        public string CpbAgeban { get; set; }
        public string CpbConban { get; set; }
        public string CpbChqban { get; set; }
        public DateTime? CpbChqdatpag { get; set; }
        public string CpbCartnum { get; set; }
        public int? CpbTipmovban { get; set; }
        public int? CpbExtorno { get; set; }
        public int? CpbSit { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? Id26 { get; set; }
        public DateTime? CppDatvct { get; set; }
        public double? CppValpagar { get; set; }
        public int? CppUsuarioIdAlt { get; set; }
        public DateTime? CppDataAlt { get; set; }
        public int? AgepagId { get; set; }
        public string OpcCreDeb { get; set; }
        public string OpcCalcTaxa { get; set; }
        public int? QtdParcCre { get; set; }
        public string CpbChqOpcUniVarios { get; set; }
        public string CpbChqOpcProprioTerceiro { get; set; }
        public string CpbChqNmTerceiro { get; set; }
        public string CpbCpfcnpj { get; set; }
    }
}
