using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsContratosRag
    {
        public GsContratosRag()
        {
            GsContratosRagVisitas = new HashSet<GsContratosRagVisitas>();
        }

        public int CttId { get; set; }
        public int AssId { get; set; }
        public int? RagorcId { get; set; }
        public int? CttNum { get; set; }
        public int? CttDiavct { get; set; }
        public int? CttTipo { get; set; }
        public int? CttSit { get; set; }
        public int? CttNumlic { get; set; }
        public decimal? CttValmens { get; set; }
        public DateTime? CttDataprv { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public decimal? CttValdatacenter { get; set; }
        public int? TabnfeId { get; set; }
        public DateTime? DataContrato { get; set; }
        public double? EspacoContratado { get; set; }
        public double? EspacoDescontado { get; set; }
        public double? EspacoLogDescontado { get; set; }
        public int? CttVisitasContratadas { get; set; }
        public int? CttMesReajuste { get; set; }
        public int? CttIndiceReajuste { get; set; }
        public double? CttNfeReajusteMensal { get; set; }
        public double? CttNfeReajusteExtra { get; set; }
        public DateTime? CttNfeDataultAlt { get; set; }
        public double? CttNfseReajusteMensal { get; set; }
        public DateTime? CttNfseDataultAlt { get; set; }
        public int? CttNumlicapp { get; set; }

        public virtual ICollection<GsContratosRagVisitas> GsContratosRagVisitas { get; set; }
    }
}
