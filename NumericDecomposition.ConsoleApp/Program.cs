using NumericDecomposition.Domain;
using System;
using System.Linq;

namespace NumericDecomposition.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var requestNumber = true;
            var number = 0;

            while (requestNumber)
            {
                Console.Write("Digite um número: ");
                var line = Console.ReadLine();

                if (int.TryParse(line, out number))
                    requestNumber = false;
                else
                    Console.WriteLine($"O texto informado ({line}) não é um número inteiro válido.");
            }

            var decomposition = new Decomposition(number);

            if (decomposition.has_error)
                Console.WriteLine($"Ocorreu um erro ao decompor o número {number}");
            else
            {
                Console.WriteLine($"Numero de entrada: {number}");
                Console.WriteLine($"Numeros divisores: {String.Join(", ", decomposition.divisors.OrderBy(x => x))}");
                Console.WriteLine($"Divisores primos: {String.Join(", ", decomposition.prime_divisors.OrderBy(x => x))}");
            }
        }
    }
}