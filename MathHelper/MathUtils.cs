using System;
using System.Collections.Generic;

namespace MathHelper
{
    public static class MathUtils
    {
        public static IEnumerable<int> NumerosDivisores(int valorMaximo)
        {
            List<int> divisores = new List<int>();

            // Não podemos prosseguir com números negativos
            valorMaximo = valorMaximo < 0 ? -valorMaximo : valorMaximo;

            int raiz = (int)Math.Sqrt(valorMaximo);

            // Busca apenas até a raiz quadrada de valorMaximo e não divide números ímpares por números pares
            for (int i = 1, passo = (int)(valorMaximo % 2 == 0 ? 1 : 2); i <= raiz; i += passo)
            {
                // Seleciona 2 divisores por vez, i e valorMaximo/i
                if (valorMaximo % i == 0)
                {
                    divisores.Add(i);
                    divisores.Add((int)valorMaximo / i);
                }
            }
            // Selecionando a raiz no caso de quadrado perfeito
            if (raiz * raiz == valorMaximo)
                divisores.Add(raiz);

            divisores.Sort();

            return divisores;
        }

        public static IEnumerable<int> NumerosPrimos(IEnumerable<int> lista)
        {
            List<int> resultado = new List<int>();

            foreach (int numero in lista)
            {
                if (EhPrimo(numero))
                    resultado.Add(numero);
            }

            return resultado;
        }

        public static bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            var limite = (int)Math.Floor(Math.Sqrt(numero));
            for (int i = 3; i <= limite; i += 2) if (numero % i == 0) return false;
            return true;
        }
    }
}
