using System;
using System.Collections.Generic;
using System.Text;

namespace DespesasDaCasa
{
    [Serializable]
    enum Estado
    {
        divida = 1,
        pago = 2,
        atraso = 3

    }

    [Serializable]
    class Despesa
    {
        public string descricao;
        public int ano;
        public int mes;
        public int dia;
        public float valor;
        public Estado estado;

        public Despesa(string descricao, int ano, int mes, int dia, float valor)
        {
            this.descricao = descricao;
            this.ano = ano;
            this.mes = mes;
            this.dia = dia;
            this.valor = valor;
            this.estado = Estado.divida;
        }
        /***
         * construtor que permite recebr o enum como string
         * 06/01/2022
         * 
         * ***/
        public Despesa(string descricao, int ano, int mes, int dia, float valor, string estadoRecebido)
        {
            this.descricao = descricao;
            this.ano = ano;
            this.mes = mes;
            this.dia = dia;
            this.valor = valor;


            if(!Enum.TryParse(estadoRecebido, out this.estado)){
                this.estado = Estado.divida;
            }
        }

        public Despesa(string linhaDeFicherio)
        {
            this.ano = Int32.Parse(linhaDeFicherio.Split("*")[0]);
            this.mes = Int32.Parse(linhaDeFicherio.Split("*")[1]);
            this.dia = Int32.Parse(linhaDeFicherio.Split("*")[2]);
            this.descricao = linhaDeFicherio.Split("*")[3];
            this.valor = float.Parse(linhaDeFicherio.Split("*")[4]);

            Enum.TryParse(linhaDeFicherio.Split("*")[5], out this.estado);

        }

        //Override do toString
        public override string ToString()
        {
            return ano + "/" + mes + "/" + dia + "->" + descricao + " " + valor + " euros " + estado.ToString();
        }

        public string toStringSave()
        {
            return ano + "*" + mes + "*" + dia + "*" + descricao + "*" + valor + "*" + estado.ToString();
        }
    }
}
