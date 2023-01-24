using System;

namespace PositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número: ");

            numero = int .Parse(Console.ReadLine());

            if (numero >=0 )
            {
                Console.WriteLine("*** Número Positivo ***");
            }

            else if (numero < 0)
            {
                Console.WriteLine("*** Número Negativo ***");
            }

            Console.ReadKey();

        }
    }
}
