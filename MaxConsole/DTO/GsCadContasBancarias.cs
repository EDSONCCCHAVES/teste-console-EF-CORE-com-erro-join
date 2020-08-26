using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsCadContasBancarias
    {
        public int CadconbanId { get; set; }
        public int AssId { get; set; }
        public int? CliforId { get; set; }
        public int? BanId { get; set; }
        public string CadconbanAge { get; set; }
        public string CadconbanConta { get; set; }
        public int? CadconbanTipo { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? CadconbanTerc { get; set; }
        public string CadconbanNome { get; set; }
        public string CadconbanCpf { get; set; }
        public string CadconbanParentesco { get; set; }
        public DateTime? CadconbanAbertura { get; set; }
        public string CadconbanNomeage { get; set; }
        public string CadconbanGerente { get; set; }
        public string CadconbanFone { get; set; }
        public bool? ConPadrao { get; set; }
    }
}
