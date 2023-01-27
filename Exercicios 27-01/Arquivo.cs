using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_27_01
{
    internal class Arquivo
    {
        //contrutor
        public Arquivo() { }


        //variaveis
        string caminhoDoArquivo;
        string nomeDoArquivo;
        string conteudoDoArquivo;
        string arquivo;

        //atributos
        public string CaminhoDoArquivo 
        { 
            get { return caminhoDoArquivo; } 
            set { caminhoDoArquivo = value; } 
        }
        public string NomeDoArquivo
        {
            get { return nomeDoArquivo; }
            set { nomeDoArquivo = value; }
        }
        public string ConteudoDoArquivo
        {
            get { return conteudoDoArquivo; }
            set { conteudoDoArquivo = value; }
        }
        
        //métodos
        public string Escrever()
        {
            if (arquivo == null) 
            throw new Exception("CRIE O ARQUIVO");

            return "ESCREVA O CONTEUDO DO ARQUIVO";
        }       

        public string Ler()
        {
            return "LEIA O CONTEUDO DO ARQUIVO";
        }



    }
}
