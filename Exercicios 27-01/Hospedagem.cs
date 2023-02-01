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
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public int NumDias { get; set; }
        public double Valor { get; set; }


        //métodos
        public int ReservarQuarto()
        {
            return NumQuartos;
        }

        public double CalcularCustos()
        {
            int valor = NumQuartos * NumDias;
            return valor;
            
        }

    }
}
