using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsRequisicoesComprasItens
    {
        public int ReqcomiteId { get; set; }
        public int AssId { get; set; }
        public int? ReqcomId { get; set; }
        public int? MatId { get; set; }
        public int? EtqId { get; set; }
        public int? ReqcomiteQtd { get; set; }
        public int? ReqcomiteQtdcom { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? FunId { get; set; }
        public DateTime? ReqcomiteDatanecessidade { get; set; }
        public int? ServId { get; set; }
        public int? ServTipo { get; set; }
        public string ServDes { get; set; }
        public string ReqcomiteObs { get; set; }
        public string ReqcomiteTipo { get; set; }
        public string ServUnidade { get; set; }
        public string ReqcomiteDescr { get; set; }
        public int? ReqcomiteOrcId { get; set; }
    }
}
