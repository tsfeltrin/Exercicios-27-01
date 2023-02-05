using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_27_01
{
    internal class Hospedagem
    {
        //atributos
        public string NomeHotel { get; set; }
        public string Endereco { get; set; }
        public int NumQuartos { get; set; }
        public double PrecoDiaria { get; set; }
        private DateTime CheckIn { get; set; }
        private DateTime CheckOut { get; set; }
        
        // construtor com parâmetros
        public Hospedagem(string NomeHotel, string Enderco, int NumQuartos, double PrecoDiaria, DateTime CheckIn, DateTime CheckOut)
        {
            this.NomeHotel = NomeHotel;
            this.Endereco = Enderco;
            this.NumQuartos = NumQuartos;
            this.PrecoDiaria = PrecoDiaria;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
        }

        public Hospedagem() { }

        //métodos
        public void ReservarQuarto()
        {
            TimeSpan duracao = CheckOut - CheckIn;
            int dias = duracao.Days;
            if (dias > 5)
            {
                Console.WriteLine("Não há quartos disponíveis para reserva");
            }
            else
            {
                Console.WriteLine("Quarto disponível para reserva");
            }           
        }

        public void CalcularCustos()
        {
            TimeSpan duracao = CheckOut - CheckIn;
            int dias = duracao.Days;
            double custo = dias * PrecoDiaria;
            Console.WriteLine("Custo total da hospedagem: R$ " + custo);            
        }
    }
}
