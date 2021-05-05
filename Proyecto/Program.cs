 using Autofac;
using Abstracciones;

using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)

        {
            var contenedorIoC = ConfiguracionIoC.GenerarContenedor();
            Console.WriteLine("Ingrese el numero 1");
            var numero1string = Console.ReadLine();
            int numero1 = 0;

            while (!int.TryParse(numero1string, out numero1))
            {
                Console.WriteLine("Ingrese el numero 1 de nuevo");
                numero1string = Console.ReadLine();
            }


            Console.WriteLine("Ingrese el numero 2");
            var numero2string = Console.ReadLine();
            int numero2 = 0;

            while (!int.TryParse(numero2string, out numero2))
            {
                Console.WriteLine("Ingrese el numero 2 de nuevo");
                numero2string = Console.ReadLine();
            }


            int producto = contenedorIoC.Resolve<IMultiplicador>().multiplicarNumeros(numero1, numero2);
            Console.WriteLine($"el producto es: {producto}");
            Console.ReadLine();

        }
    }

}
