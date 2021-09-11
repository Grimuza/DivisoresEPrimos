using MathHelper;
using System;
using System.Collections.Generic;

namespace DivisoresEPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número entre 1 e 2.147.483.647: ");
                int valorMaximo = int.Parse(Console.ReadLine());

                Console.WriteLine("Número de Entrada: {0:D}", valorMaximo);

                Console.Write("Números divisores: ");
                IEnumerable<int> divisores = MathUtils.NumerosDivisores(valorMaximo);
                ImprimeListaNumerica(divisores);
                Console.WriteLine();

                Console.Write("Números primos: ");
                ImprimeListaNumerica(MathUtils.NumerosPrimos(divisores));

                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("O valor digitado não é um número entre 1 e 2.147.483.647");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ImprimeListaNumerica(IEnumerable<int> listaNumerica) 
        {
            foreach (int valor in listaNumerica)
            {
                Console.Write("{0:D} ", valor);
            }
        }
    }
}
