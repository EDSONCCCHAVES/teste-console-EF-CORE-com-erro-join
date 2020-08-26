using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsChamadoTecnico
    {
        public int ChatecId { get; set; }
        public int AssId { get; set; }
        public int? CliforId { get; set; }
        public int? FunId { get; set; }
        public int? OcoateId { get; set; }
        public int? ChatecNum { get; set; }
        public string ChatecContato { get; set; }
        public string ChatecDdd { get; set; }
        public string ChatecTel { get; set; }
        public string ChatecEmail { get; set; }
        public string ChatecAssunto { get; set; }
        public DateTime? ChatecVisitadata { get; set; }
        public int? ChatecVisitahora { get; set; }
        public string ChatecInformacoes { get; set; }
        public string ChatecObservacoes { get; set; }
        public string ChatecRelatorio { get; set; }
        public int? ChatecSit { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? EvtId { get; set; }
    }
}
