using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aplicación de consola que solo acepta un numero 
                de dos cifras e imprime el mismo numero invertido. */

            while (true)
            {
                Console.Clear();

                Console.Write("Introduzca un numero de dos cifras: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 10 && n < 100)
                {
                    int nInvertido = Invertir(n);

                    Console.WriteLine("Numero invertido: {0:D2}", nInvertido);
                    break;
                }
                else
                {
                    Console.WriteLine("\nEl numero introducido no posee dos cifras,                                                                                                                            vuelva a intentarlo...");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }

        private static int Invertir(int num)
        {
            int resul = 0;

            while (num > 0)
            {
                resul = resul * 10 + num % 10;
                num /= 10;
            }

            return resul;
        }

    }
}
