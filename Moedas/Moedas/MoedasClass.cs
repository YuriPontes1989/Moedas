
using System;
using System.Collections.Generic;
using System.Text;

namespace Moedas
{
    class MoedasClass
    {

        public static double moedas;
        public static double valor;
        public static double Ifin = 1.06;


        public static double Reais()//Calcular em real
        {
            return moedas * (valor * Ifin);
        }
    }
}