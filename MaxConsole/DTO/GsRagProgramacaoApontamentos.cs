﻿using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRagProgramacaoApontamentos
    {
        public int ProgaponId { get; set; }
        public int AssId { get; set; }
        public int? DesenId { get; set; }
        public int? FunId { get; set; }
        public string ProgaponDescricao { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? SysDel { get; set; }
    }
}
