using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAtualizacaoSistema
    {
        public int AtusisId { get; set; }
        public DateTime? AtusisData { get; set; }
        public int? AtusisVercod1 { get; set; }
        public int? AtusisVercod2 { get; set; }
        public int? AtusisVercod3 { get; set; }
        public int? AtusisVercod4 { get; set; }
        public string AtusisInfo { get; set; }
        public int? AssId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
    }
}
