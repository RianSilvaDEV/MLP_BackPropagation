using System;
using System.Collections.Generic;
using System.Text;

namespace MLP_BackPropagation
{
    public class sigmoid
    {
        public static double saida(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        public static double derivada(double x)
        {
            return x * (1 - x);
        }
    }
}
