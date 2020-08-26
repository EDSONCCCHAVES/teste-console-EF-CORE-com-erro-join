using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsMateriais
    {
        public int MatId { get; set; }
        public int AssId { get; set; }
        public int? AmxId { get; set; }
        public int? GrpmatId { get; set; }
        public string MatCodbar { get; set; }
        public string MatDes { get; set; }
        public int? UnidId { get; set; }
        public double? MatQtdestatu { get; set; }
        public double? MatQtdestmin { get; set; }
        public double? MatQtdestres { get; set; }
        public decimal? MatUltprecocompra { get; set; }
        public DateTime? MatUltdatacompra { get; set; }
        public decimal? MatTotalcompra { get; set; }
        public decimal? MatPrecovenda { get; set; }
        public DateTime? MatUltdatavenda { get; set; }
        public int? MatListapreco { get; set; }
        public string MatImg { get; set; }
        public int? MatCod { get; set; }
        public int? MatfabId { get; set; }
        public double? MatQtdestdisp { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string MatObs { get; set; }
        public int? CencusgrpId { get; set; }
        public int? ImpId { get; set; }
        public int? MatPrazorecebimento { get; set; }
        public double? MatPeso { get; set; }
        public int? TabncmId { get; set; }
        public double? MatDensidade { get; set; }
        public double? MatVolume { get; set; }
        public string MatReferencia { get; set; }
        public short CobraMaterial { get; set; }
    }
}
