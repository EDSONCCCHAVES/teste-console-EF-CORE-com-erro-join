using System;
using System.Collections.Generic;

namespace MaxConsole.DTO
{
    public partial class GaTarefasDiarias
    {
        public int Id { get; set; }
        public int? AssId { get; set; }
        public int? DesenId { get; set; }
        public string TdsTitulo { get; set; }
        public int? FunId { get; set; }
        public string FunNome { get; set; }
        public string TdsSolicitante { get; set; }
        public string TdsDescricao { get; set; }
        public int? TdsStatus { get; set; }
        public string TdsTempogasto { get; set; }
        public DateTime TdsDatainicio { get; set; }
        public DateTime TdsDatafim { get; set; }
        public string TdsCliente { get; set; }
        public int? TdsCor { get; set; }
        public int? TdsTipo { get; set; }
        public int? TdsFimatual { get; set; }
        public int? TdsInicioatual { get; set; }
        public DateTime? TdsDataalerta { get; set; }
        public int? TdsMinutosalerta { get; set; }
        public int? TdsOpcoes { get; set; }
        public string TdsAssunto { get; set; }
        public int? TdsIdrepeticao { get; set; }
        public string TdsInforepeticao { get; set; }
        public DateTime SysDatcad { get; set; }
        public int SysDel { get; set; }
    }
}
