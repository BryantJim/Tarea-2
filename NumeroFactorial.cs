using System;

namespace NumeroFactorial
{
    class NumeroFactorial
    {
        static void Main(string[] args)
        {
            int Numero;
            String Entrada = "";

            Console.Write("Introduca el numero para saber su factorial: ");
            Entrada = Console.ReadLine();
            Numero = Convert.ToInt32(Entrada);

            Console.WriteLine("\nEl factorial de {0} es: {1}", Numero, Factorial(Numero));
        }

        static int Factorial(int valor)
        {
            int number = 1;
            for (int x = 1; x <= valor; x++)
            {
                number *= x;
            }
            return number;
        }
    }
}

