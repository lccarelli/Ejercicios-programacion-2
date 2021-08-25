using System;
using ValidadorDeRango;

namespace PedidosAlUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int min = -101;
            int max = 100;
            int cantidadNumeros = 10;

            for (int i = 0; i < cantidadNumeros; i++) {

                Console.Write("Ingrese un numero:");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {

                    ValidadorDeRangos.Validar(numeroIngresado, min, max);
                }

            }

        }
    }
}
