using System;

namespace DespesasDaCasa
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Despesa d = new Despesa("agua", 2020, 12, 5, 12.5f);
            Despesa e = new Despesa("eletricidade", 2020, 12, 5, 18.5f);

            ListaDeDespesas lp = new ListaDeDespesas();

            lp.despesasListadas.Add(d);
            lp.despesasListadas.Add(e);*/




            /*ListaDeDespesas lp = new ListaDeDespesas(Gravador.LerListaDeDespesas().despesasListadas);
       

            Despesa d = new Despesa("TESTE", 2020, 12, 5, 12.5f, Console.ReadLine());
            lp.despesasListadas.Add(d);
            Console.WriteLine(lp);
            Gravador.GravarListaDeDespesas(lp);*/

            //GravodorPorStrings.Grava(lp.despesasListadas);
            ListaDeDespesas lp = new ListaDeDespesas();
            lp.despesasListadas = GravodorPorStrings.Ler();

            Console.WriteLine(lp);
        }
    }
}
