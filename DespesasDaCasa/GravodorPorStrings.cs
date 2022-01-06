using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DespesasDaCasa
{
    static class GravodorPorStrings
    {

        public static void Grava( List<Despesa> listaAGravar)
        {
            string local = Directory.GetCurrentDirectory();
            string nomeFicheiro = "/despesas.txt";

            StreamWriter streamWriter = new StreamWriter(local + nomeFicheiro, false);

            foreach (Despesa despesa in listaAGravar)
            {
                streamWriter.WriteLine(despesa.toStringSave());
            }

           
            streamWriter.Close();
        }

        public static List<Despesa> Ler()
        {
            List<Despesa> result = new List<Despesa>();

            string local = Directory.GetCurrentDirectory();
            string nomeFicheiro = "/despesas.txt";

           

            StreamReader streamReader = new StreamReader(local + nomeFicheiro);


     

            while (!streamReader.EndOfStream)
            {
                result.Add(new Despesa(streamReader.ReadLine()));
            }


            streamReader.Close();

            return result;
        }
    }
}
