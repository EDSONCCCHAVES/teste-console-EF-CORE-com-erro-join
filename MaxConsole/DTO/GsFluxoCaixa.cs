using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsFluxoCaixa
    {
        public int FlxcxaId { get; set; }
        public int AssId { get; set; }
        public int? PlnctssubctsId { get; set; }
        public DateTime? FlxcxaData { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string FlxcxaCor { get; set; }
        public string FlxcxaAnot { get; set; }
    }
}
