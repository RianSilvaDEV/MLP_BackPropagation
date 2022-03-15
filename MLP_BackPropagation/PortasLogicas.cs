using System;
using System.Collections.Generic;
using System.Text;

namespace MLP_BackPropagation
{
    public class PortasLogicas
    {
        public double[,] _AND { get; set; }
        public double[] SAIDA_AND { get; set; }

        public double[,] _OR { get; set; }
        public double[] SAIDA_OR { get; set; }

        public double[,] _XOR { get; set; }
        public double[] SAIDA_XOR { get; set; }

        public double[,] _XNOR { get; set; }
        public double[] SAIDA_XNOR { get; set; }

        public PortasLogicas()
        {

            _AND = new double[,] {{ 0, 0},
                               { 1, 0},
                               { 0, 1},
                               { 1, 1,}};

            SAIDA_AND = new double[] { 0, 0, 0, 1 };

            _OR = new double[,] {{ 0, 0 },
                              { 1, 0 },
                              { 0, 1 },
                              { 1, 1 },};

            SAIDA_OR = new double[] { 0, 1, 1, 1 };


            _XOR = new double[,]{{ 0, 0 },
                                { 1, 0 },
                                { 0, 1 },
                                { 1, 1 },};

            SAIDA_XOR = new double[] { 0, 1, 1, 0 };


            _XNOR = new double[,] {{ 0, 0 },
                                { 1, 0 },
                                { 0, 1 },
                                { 1, 1 },};

            SAIDA_XNOR = new double[] { 1, 0, 0, 1 };


        }

    }
}