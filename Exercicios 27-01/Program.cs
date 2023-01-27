﻿using System;

namespace Exercicios_27_01
{
    internal class Program
    {
        // 1 - Criar uma classe "ContaBancaria" com os seguintes atributos "titular"(nome), 
        //"numero"(número da conta), "saldo"(saldo atual da conta), "saque"(valor do saque) 
        //e "limite"(limite de saque).Adicionar métodos get e set para os atributos.Adicionar 
        //métodos "Depositar"(para depositar dinheiro na conta), "Sacar"(para sacar dinheiro da 
        //conta) e "ExibirSaldo"(para exibir o saldo atual da conta).
        //Deve ter um construtor com ou sem parâmetros
        //O valor limite de saque é de R$500,00 e tem um limite de 3 saques.
        //Se ultrapassar o limite do valor de saque, exibir o seguinte aviso: 
        //"VALOR DE SAQUE ULTRAPASSADO"
        //Se ultrapassar o limite de saques, exibir o seguinte aviso: 
        //"LIMITE DE SAQUE ULTRAPASSADO"

        static ContaBancaria contaBancaria;

        static Carro carro;
        static void Main(string[] args)
        {           
            contaBancaria = new ContaBancaria();
            carro = new Carro();

            //MenuBancario();
            MenuCarro();

            Console.ReadKey();             

        }

        private static void MenuBancario()
        {
            try
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Saldo");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Deposito");

                string opcao = Console.ReadLine();


                if (opcao == "1")
                {
                    double saldo = contaBancaria.ExibirSaldo();
                    Console.WriteLine("Seu saldo é: " + saldo);
                }

                if (opcao == "2")
                {
                    Console.WriteLine("Qual o valor do saque?");
                    double valor = double.Parse(Console.ReadLine());
                    string mensagem = contaBancaria.Sacar(valor);
                    Console.WriteLine(mensagem);
                }

                if (opcao == "3")
                {
                    Console.WriteLine("Qual o valor do depósito?");
                    double valor = double.Parse(Console.ReadLine());
                    string mensagem = contaBancaria.Depositar(valor);
                    Console.WriteLine(mensagem);
                }

                MenuBancario();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        private static void MenuCarro()

        // 2 - Crie uma classe "Carro" com os seguintes atributos "marca", "modelo", "ano", 
        //"velocidade".Adicionar métodos get e set para os atributos.Adicioanar os métodos
        //para acelerar, reduzir, parar 
        //Deve ter um construtor com ou sem parâmetros
        //Acelerar de 10 em 10, se ultrapassar 80km, exibir o seguinte aviso: 
        //"MULTA POR EXCESSO DE VELOCIDADE",
        //Reduzir de 5 em 5, não pode chegar a 0, se tentar reduzir a uma velocidade que fique
        //abaixo ou igual a 0, exibir a seguinte mensagem: "LIMITE DE REDUÇÃO ATINGIDO"
        //Parar só é permitido quando a velocidade for abaixo ou igual a 10, deixar a velocidade
        //com valor 0 e exibir a seguinte mensagem: "CARRO PARADO"
        {
            try
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Acelerar");
                Console.WriteLine("2 - Reduzir");
                Console.WriteLine("3 - Parar");

                string opcao = Console.ReadLine();


                if (opcao == "1")
                {
                    string mensagem = carro.Acelerar();
                    Console.WriteLine(mensagem);
                }

                if (opcao == "2")
                {
                    string mensagem = carro.Reduzir();
                    Console.WriteLine(mensagem);
                }

                if (opcao == "3")
                {
                    string mensagem = carro.Parar();
                    Console.WriteLine(mensagem);
                }

                MenuCarro();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }               

        // 3 - Criar uma classe "Aluno" com os seguintes atributos "nome", "matricula", "notas" 
        //e média. O atributo notas deve ser um array contendo as 4 notas do aluno.Adicionar 
        //métodos get e set para os atributos.Adicione o método para calulcar a média do aluno
        //Deve ter um construtor com ou sem parâmetros
        //Exibir a mensagem "APROVADO" com média maior e igual que 7
        //"RECUPERAÇAÕ" com a média entre 6 e 5.
        //"REPROVADO" com a média abaixo de 5
             
        //DÚVIDA!!!!!!



        // 4 - Criar uma classe "Aquivo" com os seguintes atributos "caminho"(caminho do arquivo), 
        //"nome"(nome do arquivo) e "conteudo"(conteúdo do arquivo). Adicionar métodos get 
        //e set para os atributos. Deve ter um método para "escrever" e "ler" o conteúdo do 
        //arquivo Deve ter um construtor com ou sem parâmetros Se não encontrar o arquivo, 
        //deve criar o arquivo

        


        // 5 - Criar uma classe "Hospedagem" com os seguintes atributos "nomeHotel", "endereco", 
        //"numQuartos", "precoDiaria", checkIn e checkOut.Adicionar métodos get e set para 
        //os atributos. Ela também possui método "ReservarQuarto" que verifica se há quartos
        // disponíveis para reserva de acordo com o checkIn e checkOut escolhido, método 
        //"CalcularCusto" que calcula o custo total da hospedagem com base no número de dias 
        // escolhido no checkIn e checkOut.


    }
}