using System;

namespace ejerciciosNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 5;
            PiramideA(n);
            Console.WriteLine();
            PiramideB(n);
            Console.WriteLine();
            PiramideC(n);
            Console.WriteLine();
            PiramideD(n);

            Console.WriteLine();
            int numero = 2;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"Potencia iterativo {numero}^{i}: {PotenciaIterativo(numero, i)}"); ;
                Console.WriteLine($"Potencia recursivo {numero}^{i}: {PotenciaRecursivo(numero, i)}"); ;
            }

            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Fibonacci iterativo de {i}: {FibonacciIterativo(i)}");
                Console.WriteLine($"Fibonacci recursivo de {i}: {FibonacciRecursivo(i)}");
            }
        }

        /// <summary>
        /// 1
        /// 12
        /// 123
        /// </summary>
        /// <param name="n"></param>
        static void PiramideA(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 123
        /// 12
        /// 1
        /// </summary>
        /// <param name="n"></param>
        static void PiramideB(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(j - i + 1);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// ..1
        /// .21
        /// 321
        /// </summary>
        /// <param name="n"></param>
        static void PiramideC(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n - i + 1; j++)
                {
                    Console.Write(".");
                }
                for (int k = 1; k < i + 1; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 321
        /// .21
        /// ..1
        /// </summary>
        /// <param name="n"></param>
        static void PiramideD(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(".");
                }
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(n - j + 1 - i + 1);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Calcula la potencia de manera iterativa
        /// </summary>
        /// <param name="numero">base</param>
        /// <param name="exponente">exponente</param>
        /// <returns>numero ^ exponente</returns>
        static double PotenciaIterativo(int numero, int exponente)
        {
            if (exponente == 0) return 1;

            double result = numero;
            for (int i = 2; i <= exponente; i++)
            {
                result = numero * result;
            }
            return result;
        }

        /// <summary>
        /// Calcula la potencia de manera recursiva
        /// </summary>
        /// <param name="numero">base</param>
        /// <param name="exponente">exponente</param>
        /// <returns>numero ^ exponente</returns>
        static double PotenciaRecursivo(int numero, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }
            else
            {
                return numero * PotenciaRecursivo(numero, exponente - 1);
            }
        }



        /// <summary>
        /// Fibonacci iterativo
        /// </summary>
        /// <param name="n">Elemento de la serie deseado</param>
        /// <returns>n-esimo elemento de la serie</returns>
        static double FibonacciIterativo(int n)
        {
            double a = 0;
            double b = 1;
            double c = 0;

            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        /// <summary>
        /// Fibonacci recursivo
        /// </summary>
        /// <param name="n">Elemento de la serie deseado</param>
        /// <returns>n-esimo elemento de la serie</returns>
        static double FibonacciRecursivo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }
    }
}
