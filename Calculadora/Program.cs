using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================== CALCULADORA ====================");
            Console.WriteLine();
            Console.WriteLine("DIGITE O PRIMEIRO NUMERO: ");
            int valor1 = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("DIGITE O SEGUNDO NUMERO: ");
            int valor2 = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("INFORME A OPERAÇÃO DESEJADA: ");
            Console.WriteLine("1 = SOMA");
            Console.WriteLine("2 = SUBTRAÇÃO");
            Console.WriteLine("3 = MULTIPLICAÇÃO");
            Console.WriteLine("4 = DIVISÃO");
            int operacao = int.Parse(Console.ReadLine().ToString());
            double resultadoOperacao = 0;

            switch (operacao)
            {
                case 1:
                    resultadoOperacao = Soma(valor1, valor2);
                    break;
                case 2:
                    resultadoOperacao = Subtração(valor1, valor2);
                    break;
                case 3:
                    resultadoOperacao = Multiplicação(valor1, valor2);
                    break;
                case 4:
                    resultadoOperacao = Divisão(valor1, valor2);
                    break;
            }

            Console.WriteLine("RESULTADO = " + resultadoOperacao);

        }

        private static double Soma(int valor1, int valor2) => valor1 + valor2;

        private static double Subtração(int valor1, int valor2) => valor1 - valor2;

        private static double Multiplicação(int valor1, int valor2) => valor1 * valor2;

        private static double Divisão(int valor1, int valor2) => valor1 / valor2;

    }
}