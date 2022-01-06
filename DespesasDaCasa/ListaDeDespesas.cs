using System;
using System.Collections.Generic;
using System.Text;

namespace DespesasDaCasa
{
    [Serializable]
    class ListaDeDespesas
    {
        public List<Despesa> despesasListadas;

        //Cria lista vazia
        public ListaDeDespesas()
        {
            this.despesasListadas = new List<Despesa>();
        }

        //Carregar lista gravada
        public ListaDeDespesas(List<Despesa> L)
        {
            this.despesasListadas = L;
        }

        //TO STRING
        public override string ToString()
        {
            string result = "";

            /* despesasListadas.ForEach(x =>
             {

             });*/

            foreach (Despesa despesa in despesasListadas)
            {
                result += despesa.ToString() + "\n";
            }

            return result;
        }
    }
}
