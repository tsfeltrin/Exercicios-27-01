using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_27_01
{
    internal class ContaBancaria
    {
        //variáveis
        string titular;
        int numeroDaConta;
        double saldo;
        double saque;
        double limite;
        int quantidadeSaque;
        double valorSacado;
        int qtdSacado;

        //propriedades ou atributos
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public int NumeroDaConta
        {
            get { return numeroDaConta; }
            set { numeroDaConta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public double Saque
        {
            get { return saque; }
            set { saque = value; }
        }
        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public int QuantidadeSaque
        {
            get { return quantidadeSaque; }
            set { quantidadeSaque = value; }
        }
        public double ValorSacado
        {
            get { return valorSacado; }
            set { valorSacado = value; }
        }
        public int QtdSacado
        {
            get { return qtdSacado; }
            set { qtdSacado = value; }
        }

        //contrutores

        public ContaBancaria()
        {
            limite = 500;
            quantidadeSaque = 3;
            saldo = 1000;
        }
        public ContaBancaria(double limiteSaque, int qtdSaque)
        {
            limite = limiteSaque;
            quantidadeSaque = qtdSaque;
        }

        //métodos
        public string Depositar(double valor)
        {
            saldo = saldo + valor;
            return "Operação Efeutada com Sucesso!";
        }
        public string Sacar(double valor)
        {
            if (valorSacado > limite || (valorSacado + valor) > limite)
            {
                throw new ArgumentException("VALOR DE SAQUE ULTRAPASSADO");
            }
            if (qtdSacado > quantidadeSaque)
            {
                throw new ArgumentException("LIMITE DE SAQUE ULTRAPASSADO");
            }

            saldo = saldo - valor;
            valorSacado = valorSacado + valor;
            qtdSacado = qtdSacado + 1;

            return "Saque Realizado com Sucesso";
        }
        public double ExibirSaldo()
        {
            return saldo;
        }

    }
}
