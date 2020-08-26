using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GtLogSugestoesRecebimentos
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int BorderoRecebimentoId { get; set; }
        public int BorderoRecebimentoTituloId { get; set; }
        public int ContaReceberParcelaId { get; set; }
        public int ContaReceberBaixaId { get; set; }
        public int FormaRecebimentoId { get; set; }
        public decimal LsrValparcela { get; set; }
        public decimal LsrValjuros { get; set; }
        public decimal LsrValmulta { get; set; }
        public decimal LsrValdesconto { get; set; }
        public decimal LsrValoutros { get; set; }
        public decimal LsrValrecebimento { get; set; }
        public byte[] LsrAuditoria { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
    }
}
