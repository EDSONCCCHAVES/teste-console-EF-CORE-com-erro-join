using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsControleVersaoPublicacao
    {
        public int ConverpubId { get; set; }
        public int AssId { get; set; }
        public string ConverpubVersao { get; set; }
        public string ConverpubFile { get; set; }
        public double? ConverpubSize { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
