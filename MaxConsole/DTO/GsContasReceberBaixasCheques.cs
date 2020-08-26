using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContasReceberBaixasCheques
    {
        public int Id { get; set; }
        public int AssId { get; set; }
        public int ContaReceberBaixaId { get; set; }
        public int BancoId { get; set; }
        public int ContaBancariaId { get; set; }
        public string CrbcAgenciaBancaria { get; set; }
        public string CrbcContaBancaria { get; set; }
        public DateTime? CrbcDatcheque { get; set; }
        public DateTime? CrbcDatpagto { get; set; }
        public double CrbcRateio { get; set; }
        public double CrbcValcheque { get; set; }
        public int SysDel { get; set; }
        public DateTime SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }

        public virtual GsAssociados Ass { get; set; }
        public virtual GsBancos Banco { get; set; }
        public virtual GsContasBancarias GsContasBancarias { get; set; }
        public virtual GsContasReceberBaixas GsContasReceberBaixas { get; set; }
    }
}
