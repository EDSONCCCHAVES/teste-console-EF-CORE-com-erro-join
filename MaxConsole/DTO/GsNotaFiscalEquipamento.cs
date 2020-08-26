using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsNotaFiscalEquipamento
    {
        public int NfEquipamentoId { get; set; }
        public int AssId { get; set; }
        public int? NfId { get; set; }
        public int? EptaprId { get; set; }
        public int? EqtserId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? NfEquipamentoQtd { get; set; }
        public decimal? NfEquipamentoPreco { get; set; }
        public decimal? NfEquipamentoTotal { get; set; }
        public int? NfEquipamentoTipo { get; set; }
        public string NfEquipamentoDescricao { get; set; }
        public int? NfEquipamentoDevolvido { get; set; }
        public int? NfEquipamentoQtdDevolvido { get; set; }
        public string NfEquipamentoTerceiro { get; set; }
        public int? NfIdOrigem { get; set; }
        public int? CfopId { get; set; }
    }
}
