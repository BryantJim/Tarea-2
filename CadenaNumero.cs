//https://github.com/BryantJim/Tarea-2.git

using System;

namespace CadenaNumero
{
    class CadenaNumero
    {
        static void Main(string[] args)
        {
            String Entrada = "";
            int Numero;

            Console.Write("Ingrese un numero(1-10) para decirlo en cadena: ");
            Entrada = Console.ReadLine();
            Numero = Convert.ToInt32(Entrada);

            NumeroCadena(Numero);
        }

        static void NumeroCadena(int Numero)
        {
            if (Numero == 1)
                Console.WriteLine("Uno");
            if (Numero == 2)
                Console.WriteLine("Dos");
            if (Numero == 3)
                Console.WriteLine("Tres");
            if (Numero == 4)
                Console.WriteLine("Cuatro");
            if (Numero == 5)
                Console.WriteLine("Cinco");
            if (Numero == 6)
                Console.WriteLine("Seis");
            if (Numero == 7)
                Console.WriteLine("Siete");
            if (Numero == 8)
                Console.WriteLine("Ocho");
            if (Numero == 9)
                Console.WriteLine("Nueve");
            if (Numero == 10)
                Console.WriteLine("Diez");
            if (Numero < 1 && Numero > 10)
                Console.WriteLine("Numero no tiene cadena en este programa");
        }
    }
}

