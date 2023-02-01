using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_27_01
{
    internal class Aluno
    {
        //string nome;
        //int matricula;
        //int notas;
        //int media;
        //as variáveis não são necessárias porque a forma escrita do get e set já as criam automaticamente conforme abaixo;

        //Atributos ou Propriedades:
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double[] Notas { get; set; }//Array
        public double Media { get; set; }

        //Construtor:
        public Aluno()
        {
            Notas = new double[] {2.5, 5, 1.9, 8.8}; 
        }
        //Método ou Função
        public string MediaAluno()
        {
            double somaNotas = Notas[0] + Notas[1] + Notas[2] + Notas[3];
            Media = somaNotas / 4;
            
            if (Media >= 7)
            {
                return "APROVADO";
            }
            else if (Media >= 5 || Media <= 6.99)
            {
                return "RECUPERAÇÃO";
            }
            else
            {
                return "REPROVADO";
            }            

        }
    }

    
}
