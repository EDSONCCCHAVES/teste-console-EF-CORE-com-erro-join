using MaxConsole.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MaxConsole
{
    class Program
    {
        //class maxdbcontex : DbContext
        //{
        //    protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        //    {
        //        OptionsBuilder.UseSqlServer("Data Source=MAX\\SQLEXPRESS;" +
        //            "Initial Catalog=db603;" +
        //            "Integrated Security=True");
        //    }

        //}
        static void Main(string[] args)
        {
            String nME_EMPRESA = "GRUPO MULTI EVENTOS LTDA";
            String nME_CIDADE = "CAMACARI";
            String END_EMPRESA = "AV. RIO BANDEIRA 212";
            String VAR_ATIVO = "SIM";
            String VAR_PLACA = "        ";
            String ANO_PLACA = "    ";
            int cont = 1;
            using (var MaxDb = new db603Context())
            {
                var inova = from des in MaxDb.GsEquipamentosApresentacao
                            join seria in MaxDb.GsEquipamentosSerie
                            join equipe in MaxDb.GsEquipamentos on des.EptId equals equipe.EtqId
                            join almoxarifado in MaxDb.GsAlmoxarifados on seria.AmxId equals almoxarifado.AmxId into almox
                            from a in almox.DefaultIfEmpty()
                            join ccusto in MaxDb.GsCentroCusto on equipe.CencusgrpId equals ccusto.CencusgrpId into custo
                            from c in custo.DefaultIfEmpty()
                            join grupo in MaxDb.GsEquipamentosGrupos on equipe.GrpeqtId equals grupo.GrpeqtId into grup
                            from g in grup.DefaultIfEmpty()
                            join FAMILIA in MaxDb.GsEquipamentosFamilias on equipe.FameqtId equals FAMILIA.FameqtId into famil
                            from f in famil.DefaultIfEmpty()
                            join FABRICA in MaxDb.GsEquipamentosFabricantes on seria.FabeqtId equals FABRICA.FabeqtId into fabi
                            from fa in fabi.DefaultIfEmpty()
                            where seria.EqtserNumpat.Contains("00")
                            select new
                            {
                                contador = cont,
                                Empresa = nME_EMPRESA,
                                Local = nME_CIDADE,
                                Planta = END_EMPRESA,
                                Ambiente = "SEDE",
                                Outro = "outro",
                                //CentroCusto = c.CencusgrpDes,
                                RFID = seria.EqtserNumpat,
                                Conta = "SONORIZACAO",
                                VAR_ATIVO = "SIM",
                                VAR_PLACA = "        ",
                                ANO_PLACA = "    "
                            };
                var result = inova.ToList();
                foreach (var ser in inova)
                {
                    Console.Write(ser.Ambiente+"  ");
                    Console.Write(ser.Local + "  ");
                    Console.Write(ser.Planta + "  ");
                    Console.Write(ser.Ambiente + "  ");
                    Console.Write(ser.Ambiente + "  ");
                    Console.Write(ser.Outro + "  ");
        //            Console.Write(ser.CentroCusto + "  ");
                    Console.Write(ser.RFID + "  ");
                    Console.Write(ser.Conta + "  ");
                    Console.WriteLine();
                    cont++;
                }
                //        var retorno = new BuscarCodigoId();
                //        Console.WriteLine(retorno);

                //   }
            }
        }
    }
}