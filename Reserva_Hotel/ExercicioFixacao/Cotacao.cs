﻿namespace ExercicioFixacao
{
    internal class Cotacao
    {

        public static double IOF = 6.0;

        public static double DolarParaReal(double quantia , double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100;
        }

    }
}
