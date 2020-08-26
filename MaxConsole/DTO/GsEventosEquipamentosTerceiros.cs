using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosEquipamentosTerceiros
    {
        public int EvteqtterId { get; set; }
        public int AssId { get; set; }
        public int? EvtId { get; set; }
        public int? CliforId { get; set; }
        public string EvteqtterDes { get; set; }
        public decimal? EvteqtterPrecolocacao { get; set; }
        public decimal? EvteqtterPrecorepassado { get; set; }
        public int? EvteqtterQtd { get; set; }
        public int? EvteqtterQtdcobrar { get; set; }
        public decimal? EvteqtterTotal { get; set; }
        public decimal? EvteqtterTotalcobrar { get; set; }
        public int? EvteqtterAgr { get; set; }
        public int? GrpeqtId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public DateTime? EvteqtterDatvenc { get; set; }
        public DateTime? EvteqtterRetdata { get; set; }
        public int? EvteqtterRethora { get; set; }
        public DateTime? EvteqtterDevdata { get; set; }
        public int? EvteqtterDevhora { get; set; }
        public int? CppId { get; set; }
        public int? EvteqtterDias { get; set; }
        public int? CptId { get; set; }
        public decimal? EvteqtterPrecocompra { get; set; }
        public int? NfId { get; set; }
        public int? EvteqtterLancado { get; set; }
        public int? EvteqtterQtdLancado { get; set; }
        public int? OrceqtterId { get; set; }
        public string EvteqtterContato { get; set; }
        public int? ClatitId { get; set; }
        public int? GrptitId { get; set; }
        public int? SubgrpId { get; set; }
        public string EvteqtterObs { get; set; }
    }
}
