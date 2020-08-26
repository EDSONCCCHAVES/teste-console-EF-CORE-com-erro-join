using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsOrcamentosEquipamentos
    {
        public int OrceqtId { get; set; }
        public int AssId { get; set; }
        public int? OrcId { get; set; }
        public int? EqtId { get; set; }
        public decimal? OrceqtPreco { get; set; }
        public int? OrceqtQtd { get; set; }
        public decimal? OrceqtValor { get; set; }
        public decimal? OrceqtTotal { get; set; }
        public int? OrceqtQtdmod { get; set; }
        public int? OrceqtAgr { get; set; }
        public string OrceqtObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? OrceqtView { get; set; }
        public int? OrcestiteId { get; set; }
        public int? OrceqtEqtterc { get; set; }
        public decimal? OrceqtPrecosubloc { get; set; }
        public string OrceqtObsint { get; set; }
        public int? NfId { get; set; }
        public int? OrceqtLancado { get; set; }
        public int? OrceqtQtdLancado { get; set; }
        public decimal OrceqtTotalSalas { get; set; }
    }
}
