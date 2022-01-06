using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DespesasDaCasa
{
    static class Gravador
    {

        public static void GravarListaDeDespesas(ListaDeDespesas listaClass)
        {
            string fileName = "ListaDeDespesas.carlos";

            if (File.Exists(fileName)){
                File.Delete(fileName);
            }

            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, listaClass);

            fileStream.Close();
        }

        public static ListaDeDespesas LerListaDeDespesas()
        {
            ListaDeDespesas result = new ListaDeDespesas();

            string fileName = "ListaDeDespesas.carlos";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();


                result = f.Deserialize(fileStream) as ListaDeDespesas;


                fileStream.Close();
            }
           



            return result;
        }
    }
}
