using System;

namespace MLP_BackPropagation
{
    class Program
    {

        static void Main(string[] args)
        {
            TreinarRede(0); // XOR
            /* Console.WriteLine("\n\n\n");
             TreinarRede(1); // AND
             Console.WriteLine("\n\n\n");
             TreinarRede(2); // OR
             Console.WriteLine("\n\n\n");
             TreinarRede(3); // XNOR
             Console.WriteLine("\n\n\n");*/
        }
        private static void TreinarRede(int porta)
        {

            PortasLogicas portaLogica = new PortasLogicas();
            var entradas = portaLogica._XOR;
            var desejados = portaLogica.SAIDA_XOR;
            if (porta == 1)
            {
                entradas = portaLogica._AND;
                desejados = portaLogica.SAIDA_AND;
            }
            else if (porta == 2)
            {
                entradas = portaLogica._OR;
                desejados = portaLogica.SAIDA_OR;
            }
            else if (porta == 3)
            {
                entradas = portaLogica._XNOR;
                desejados = portaLogica.SAIDA_XNOR;
            }

            Neuronio oculto1 = new Neuronio();
            Neuronio oculto2 = new Neuronio();
            Neuronio neuronioDeSaida = new Neuronio();

            oculto1.sortearPesos();
            oculto2.sortearPesos();
            neuronioDeSaida.sortearPesos();

            for (int epoca = 0; epoca < 2000; epoca++)
            {

                for (int i = 0; i < desejados.Length; i++)
                {

                    oculto1.entradas = new double[] { entradas[i, 0], entradas[i, 1] };
                    oculto2.entradas = new double[] { entradas[i, 0], entradas[i, 1] };

                    neuronioDeSaida.entradas = new double[] { oculto1.saida, oculto2.saida };

                    Console.WriteLine("{0} [AND|OR|XOR|XNOR] {1} = {2}", entradas[i, 0], entradas[i, 1], neuronioDeSaida.saida);

                    neuronioDeSaida.erro = sigmoid.derivada(neuronioDeSaida.saida) * (desejados[i] - neuronioDeSaida.saida);

                    neuronioDeSaida.ajustarPesos();

                    oculto1.erro = sigmoid.derivada(oculto1.saida) * neuronioDeSaida.erro * neuronioDeSaida.pesos[0];
                    oculto2.erro = sigmoid.derivada(oculto2.saida) * neuronioDeSaida.erro * neuronioDeSaida.pesos[1];

                    oculto1.ajustarPesos();
                    oculto2.ajustarPesos();
                       
                }

            }


        }

    }
}

