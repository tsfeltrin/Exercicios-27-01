using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_27_01
{
    //classe
    internal class Carro
    {
        string marca;
        string modelo;
        int ano;
        int velocidade;

        //atributos
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo 
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }

        //construtor
        public Carro()
        {

        }

        //métodos
        public string Acelerar()
        {
            velocidade = velocidade + 10;
            if (velocidade > 80)
            {
                throw new ArgumentException("MULTA POR EXCESSO DE VELOCIDADE");
            }
            return "CARRO ACELERADO";
        }
        public string Reduzir()
        {
            velocidade = velocidade - 5;
            if (velocidade <= 0)
            {
                throw new ArgumentException("LIMITE DE REDUÇÃO ATINGIDO");
            }
            return "CARRO DESACELERADO";
        }
        public string Parar()
        {
            if (velocidade <= 10)
            {
                Velocidade = 0;
            }
            return "CARRO PARADO";
        }

    }
}
