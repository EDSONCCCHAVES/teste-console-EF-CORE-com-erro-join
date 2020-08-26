using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class VGsContasReceberEventos
    {
        public int? CidId { get; set; }
        public int? AssId { get; set; }
        public int? EmpId { get; set; }
        public int? OrcNum { get; set; }
        public string EmpNome { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public DateTime? OrcDatapr { get; set; }
        public DateTime? CrbDatbaixa { get; set; }
        public DateTime? EvtDatfim { get; set; }
        public decimal OrcValortotal { get; set; }
        public decimal? DespesasEvento { get; set; }
        public decimal? DespesasTecnicos { get; set; }
        public decimal? DespesasBonusVendas { get; set; }
        public decimal? DespesasEquipamentoTerceiro { get; set; }
        public decimal? ValorTotalDespVariaveis { get; set; }
        public double CrpValpar { get; set; }
        public int? CrpSit { get; set; }
        public double? ValorTotalTitulo { get; set; }
    }
}
