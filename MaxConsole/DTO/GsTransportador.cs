using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsTransportador
    {
        public int TranspId { get; set; }
        public int AssId { get; set; }
        public int? CidId { get; set; }
        public string TranspNome { get; set; }
        public string TranspPlaca { get; set; }
        public string TranspEnd { get; set; }
        public string TranspNum { get; set; }
        public string TranspCpl { get; set; }
        public string TranspBairro { get; set; }
        public string TranspCnh { get; set; }
        public string TranspDddfone { get; set; }
        public string TranspFone { get; set; }
        public string TranspDddcel { get; set; }
        public string TranspCel { get; set; }
        public string TranspNextel { get; set; }
        public string TranspEmail { get; set; }
        public int? CliforId { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public string TranspUfplaca { get; set; }
        public string TranspCpfcnpj { get; set; }
        public string TranspRginest { get; set; }
        public string TranspRazaosocial { get; set; }
        public string TranspMunicipio { get; set; }
        public string TranspUf { get; set; }
        public string TranspCep { get; set; }
    }
}
