using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaAvisosDebitosParcelas
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int AvisoDebitoId { get; set; }
        public int FormaPagamentoId { get; set; }
        public int? OperadoraCartaoId { get; set; }
        public int? AvdpContaCartao { get; set; }
        public double AvdpTaxaOperadora { get; set; }
        public double AvdpCustasOperadora { get; set; }
        public int? AvdpDebitoCredito { get; set; }
        public DateTime? AvdpDatvencto { get; set; }
        public int AvdpNumparcela { get; set; }
        public double AvdpDesconto { get; set; }
        public double AvdpValboleto { get; set; }
        public double AvdpValjuros { get; set; }
        public double AvdpValmulta { get; set; }
        public double AvdpValsubtotal { get; set; }
        public double AvdpValtotal { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
    }
}
