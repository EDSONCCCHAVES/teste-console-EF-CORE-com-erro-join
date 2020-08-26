using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsManutencaoHistoricoReajuste
    {
        public int Id { get; set; }
        public int? CttNum { get; set; }
        public DateTime? DataReajuste { get; set; }
        public DateTime? DataContribuicao { get; set; }
        public double? EspacoContratado { get; set; }
        public decimal? ValorManutencao { get; set; }
        public decimal? Valor { get; set; }
        public string MesReajuste { get; set; }
        public DateTime? Reajuste { get; set; }
        public int? AnoReajuste { get; set; }
        public string Referencia { get; set; }
        public double? Indice { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorLiberado { get; set; }
        public decimal? Valorliberado1 { get; set; }
        public int AssId { get; set; }
        public DateTime SysDatcad { get; set; }
        public int? SysUsucad { get; set; }
        public DateTime? SysDatultalt { get; set; }
        public int? SysUsuultalt { get; set; }
        public DateTime? SysDatexc { get; set; }
        public int? SysUsuexc { get; set; }
        public int? GeradoFinanceiro { get; set; }
        public int? Checkado { get; set; }
        public int? CrpId { get; set; }
        public int? SysDel { get; set; }
        public int? GrupoId { get; set; }
        public int? SubgrupoId { get; set; }
        public int? ContaId { get; set; }
        public int? SubcontaId { get; set; }
        public string Obs { get; set; }
    }
}
