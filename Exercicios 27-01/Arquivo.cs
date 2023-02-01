using System;
using System.Collections.Generic;
using System.IO;
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
           bool existe = File.Exists("C:\\Temp\\texto.txt");
            if (existe == false)
            {
                File.Create("C:\\Temp\\texto.txt");
                return "Arquivo Criado";
            }
            
            else
            {
                File.WriteAllText("C:\\Temp\\texto.txt", "qualquer coisa");
                return "Arquivo escrito";
            }

        }       

        public string Ler()
        {
            string conteudo = File.ReadAllText("C:\\Temp\\texto.txt");
            return conteudo;
        }



    }
}
