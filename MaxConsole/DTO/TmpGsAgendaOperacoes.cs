using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class TmpGsAgendaOperacoes
    {
        public string StsevtDes { get; set; }
        public int EvteqtterId { get; set; }
        public int? OrcNum { get; set; }
        public int? OrcCtlrenovacao { get; set; }
        public int? CliforId { get; set; }
        public string CliforNome { get; set; }
        public int? EvtId { get; set; }
        public string EvtEventoNome { get; set; }
        public string EvtEventoLocal { get; set; }
        public DateTime? EvtDatini { get; set; }
        public DateTime? EvtDatfim { get; set; }
        public DateTime? Horaini { get; set; }
        public DateTime? Horafim { get; set; }
    }
}
