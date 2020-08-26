using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class EctLogradouro
    {
        public int LogNuSequencial { get; set; }
        public string UfeSg { get; set; }
        public int? LocNuSequencial { get; set; }
        public string LogNo { get; set; }
        public string LogNome { get; set; }
        public int? BaiNuSequencialIni { get; set; }
        public int? BaiNuSequencialFim { get; set; }
        public string LogComplemento { get; set; }
        public string LogTipoLogradouro { get; set; }
        public string LogStatusTipoLog { get; set; }
        public string LogNoSemAcento { get; set; }
        public int? Cep { get; set; }
    }
}
