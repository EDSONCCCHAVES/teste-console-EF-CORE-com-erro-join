using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GsAssociadosDocumentos
    {
        public GsAssociadosDocumentos()
        {
            GsAssociadosDocumentosOrcamentos = new HashSet<GsAssociadosDocumentosOrcamentos>();
        }

        public int AssdocId { get; set; }
        public int AssId { get; set; }
        public string AssdocDes { get; set; }
        public string AssdocInfo { get; set; }
        public int? AssdocTipo { get; set; }
        public int? AssdocLayout { get; set; }
        public DateTime? AssdocDatalt { get; set; }
        public int? AssdocVersao { get; set; }
        public int? SysDel { get; set; }
        public DateTime? SysDatcad { get; set; }
        public int? AssdocOrigem { get; set; }
        public string UsuCriacao { get; set; }
        public string UsuPublicado { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public bool? Status { get; set; }
        public bool? Cobrado { get; set; }
        public int? AssdocGravaitem { get; set; }
        public int? Orcamento { get; set; }

        public virtual ICollection<GsAssociadosDocumentosOrcamentos> GsAssociadosDocumentosOrcamentos { get; set; }
    }
}
