using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsSistemaPopup
    {
        public int SispppId { get; set; }
        public int AssId { get; set; }
        public string SispppUrl { get; set; }
        public string SispppTitulo { get; set; }
        public int? SispppHeight { get; set; }
        public int? SispppWidth { get; set; }
        public int? SispppActive { get; set; }
        public int? SispppTop { get; set; }
        public int? SispppLeft { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
