using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsLogEmail
    {
        public int Id { get; set; }
        public int? AssId { get; set; }
        public int? UserId { get; set; }
        public int? LigregId { get; set; }
        public string LogMacadress { get; set; }
        public string LogDe { get; set; }
        public string LogPara { get; set; }
        public string LogCc { get; set; }
        public string LogAssunto { get; set; }
        public string LogCorpo { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
