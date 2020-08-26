using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsEventosEquipamentosSeries
    {
        public int EvteptserId { get; set; }
        public int AssId { get; set; }
        public int EvtId { get; set; }
        public int? EptaprId { get; set; }
        public int? EqtserId { get; set; }
        public DateTime? EvteptserDatasaida { get; set; }
        public DateTime? EvteptserDataretorno { get; set; }
        public int? EvteptserSubstsaida { get; set; }
        public int? EvteptserSubstretorno { get; set; }
        public int? EvteptserSubstserid { get; set; }
        public int? EvteptserSubstremaj { get; set; }
        public string EvteptserObs { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EvteptserTiposaida { get; set; }
        public int? EvteptserTipoentrada { get; set; }
        public int? EvteptserIdorigem { get; set; }
        public int? EvteptserIddestino { get; set; }
        public int? EvteptserDevger { get; set; }
        public int? NfId { get; set; }
        public int? FunId { get; set; }
        public int? FunId2 { get; set; }
        public int? EvteptserLancado { get; set; }
        public int? EvteptserQtdLancado { get; set; }
    }
}
