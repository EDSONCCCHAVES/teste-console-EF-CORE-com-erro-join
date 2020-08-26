using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFluxoComentarios
    {
        public int FlxcomId { get; set; }
        public int AssId { get; set; }
        public int? Id { get; set; }
        public int? Cd { get; set; }
        public int? EmpId { get; set; }
        public DateTime? FlxcomData { get; set; }
        public string FlxcomInfo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
