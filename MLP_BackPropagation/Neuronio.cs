using System;
using System.Collections.Generic;
using System.Text;

namespace MLP_BackPropagation
{
    public class Neuronio
    {
        public double[] entradas = new double[2];
        public double[] pesos = new double[2];
        public double erro;

        private double pesoBias;

        private Random r = new Random();

        public double saida
        {
            get { return sigmoid.saida(pesos[0] * entradas[0] + pesos[1] * entradas[1] + pesoBias); }
        }

        public void sortearPesos()
        {
            pesos[0] = r.NextDouble();
            pesos[1] = r.NextDouble();
            pesoBias = r.NextDouble();
        }

        public void ajustarPesos()
        {
            pesos[0] += erro * entradas[0];
            pesos[1] += erro * entradas[1];
            pesoBias += erro;
        }
    }
}
