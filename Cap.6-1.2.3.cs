using System;
using System.Collections.Generic;
using System.Text;
namespace AplicacionBase
{
    class Program
    {
        // Esta es la función principal del programa
        // Aquí inicia la aplicacion
        static void Main(string[] args)
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones         
            int m = 0; // Variable de control del ciclo alumnos
            string valor ="";
            
            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; //Variable para la calificación mínima
            float maxima = 0.0f; //Variable para la calificación maxima
        // Pedimos la cantidad de salones
            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            // Creamos el arreglo
            float[][] calif = new float[salones][];
            float[] promedios = new float[salones];
            float[] minimas = new float[salones];
            float[] maximas = new float[salones];
            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) // Ciclo salones
            {
             Console.WriteLine("Dame la cantidad de alumnos para el salon {0}",n);
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            // Instanciamos el arreglo
            calif[n] = new float[cantidad];
        }
// Capturamos la información
        for(n=0;n<salones;n++) // Ciclo salones
        {
            Console.WriteLine("Salon {0}",n);
                for(m=0;m<calif[n].GetLength(0);m++) //Ciclo alumnos
                {
                    Console.Write("Dame la calificación ");
                    valor=Console.ReadLine();
                    calif [n][m]=Convert.ToSingle(valor);
                    promedio += Convert.ToSingle(valor);
                    if (Convert.ToSingle(valor) < minima)
                        minima = Convert.ToSingle(valor);
                    if (Convert.ToSingle(valor) > maxima)
                        maxima = Convert.ToSingle(valor);
                }
                promedio /= calif[n].GetLength(0);
                promedios[n] = promedio;
                promedio = 0.0f;
                minimas[n] = minima;
                maximas[n] = maxima;
                minima = 10f;
                maxima = 0f;
        }
    // Desplegamos la información
        Console.WriteLine("—— Información ——");
        for (n = 0; n<salones; n++) // Ciclo salones
        {
        Console.WriteLine("Salon {0}", n);
            for (m = 0; m<calif[n].GetLength(0); m++) // Ciclo alumnos
            {
                Console.WriteLine("El alumno {0} tiene {1} ", m,calif[n][m]);
            }
                Console.WriteLine("El promedio del Salon {0} es: {1}", n, promedios[n]);
                Console.WriteLine("La nota minima del Salon {0} es: {1}", n, minimas[n]);
                Console.WriteLine("La nota maxima del Salon {0} es: {1}", n, maximas[n]);
            }
       }
    }
}