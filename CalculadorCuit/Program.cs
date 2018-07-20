using System;

namespace CalculadorCuit
{
    class Program
    {
        static void Main(String[] args)
        {
            var calculador = new Calculador();

            var cuit = calculador.CalcularCuitPorDni(Dni.Crear(1111111, Persona.Femiemino));

            Console.WriteLine(cuit.ValorCompleto);

            Console.ReadKey();
        }
    }
}
