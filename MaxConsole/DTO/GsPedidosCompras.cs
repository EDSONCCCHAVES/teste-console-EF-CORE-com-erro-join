using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsPedidosCompras
    {
        public int PedcompId { get; set; }
        public int AssId { get; set; }
        public int? EmpId { get; set; }
        public int? PedcompNum { get; set; }
        public DateTime? PedcompData { get; set; }
        public int? PedcompSit { get; set; }
        public DateTime? PedcompDataprov { get; set; }
        public string PedcompMotcan { get; set; }
        public DateTime? PedcompDatcanc { get; set; }
        public int? CliforId { get; set; }
        public decimal? PedcompValor { get; set; }
        public DateTime? PedcompPrevent { get; set; }
        public int? PedcompItens { get; set; }
        public int? PedcompQtd { get; set; }
        public int? PedcompNumnf { get; set; }
        public string PedcompSerienf { get; set; }
        public DateTime? PedcompEmissaonf { get; set; }
        public string PedcompOperacaonf { get; set; }
        public decimal? PedcompIcmsnf { get; set; }
        public decimal? PedcompIpinf { get; set; }
        public decimal? PedcompFretenf { get; set; }
        public decimal? PedcompValornf { get; set; }
        public int? PedcompparcId { get; set; }
        public int? PednumpNumfor { get; set; }
        public string PedcompCondpag { get; set; }
        public DateTime? PedcompDatent { get; set; }
        public string PedcompTransp { get; set; }
        public string PedcompObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? FunId { get; set; }
        public int? CppId { get; set; }
        public int? ClatitId { get; set; }
        public int? GrptitId { get; set; }
        public int? SubgrpId { get; set; }
        public int? ReqcomId { get; set; }
        public int? PedcompUsecanId { get; set; }
        public int? ConpagId { get; set; }
        public string PedcompConpagObs { get; set; }
        public int? TranspId { get; set; }
        public decimal? PedcompJurofi { get; set; }
        public double? PedcompDesconto { get; set; }
        public decimal? PedcompStnf { get; set; }
        public int? CadconbanId { get; set; }
    }
}
