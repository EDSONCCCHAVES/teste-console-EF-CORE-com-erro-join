using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtLogSugestoesPagamentos
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int BorderoPagamentoId { get; set; }
        public int BorderoPagamentoTituloId { get; set; }
        public int ContaPagarParcelaId { get; set; }
        public int ContaPagarBaixaId { get; set; }
        public int FormaPagamentoId { get; set; }
        public decimal LspValparcela { get; set; }
        public decimal LspValjuros { get; set; }
        public decimal LspValmulta { get; set; }
        public decimal LspValdesconto { get; set; }
        public decimal LspValoutros { get; set; }
        public decimal LspValpagamento { get; set; }
        public byte[] LspAuditoria { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
    }
}
