using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFolhaPagamento
    {
        public int FlapagId { get; set; }
        public int AssId { get; set; }
        public int? FunId { get; set; }
        public int? TablanId { get; set; }
        public int? FlapagMes { get; set; }
        public int? FlapagAno { get; set; }
        public decimal? FlapagValor { get; set; }
        public DateTime? FlapagData { get; set; }
        public string FlapagObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? FlapagNomebanco { get; set; }
        public int? FlapagNumeroagencia { get; set; }
        public int? FlapagNumerocontacorrente { get; set; }
        public string FlapagCpf { get; set; }
        public DateTime? FlapagDatavencimento { get; set; }
    }
}
