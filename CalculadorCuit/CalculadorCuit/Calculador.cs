using System;

namespace CalculadorCuit
{
    public class Calculador
    {
        public Cuit CalcularCuitPorDni(Dni dni)
        {
            var resultado = dni.CalcularValorInicializador();

            Int32 prefijo = default(Int32);

            Int32 sufijo = default(Int32);

            switch (dni.Persona)
            {
                case Persona.Masculino:
                    resultado += 10;
                    prefijo = 20;
                    break;
                case Persona.Femiemino:
                    resultado += 38;
                    prefijo = 27;
                    break;
                case Persona.Juridica:
                    resultado += 15;
                    prefijo = 30;
                    break;
                default:
                    prefijo = resultado = 0;
                    break;
            }

            resultado %= 11;

            switch (resultado)
            {
                case 0:
                    sufijo = 0;
                    break;
                case 1:
                    prefijo = 23;
                    if (dni.Persona == Persona.Masculino)
                        sufijo = 9;
                    else if (dni.Persona == Persona.Femiemino)
                        sufijo = 4;
                    break;
                default:
                    sufijo = 11 - resultado;
                    break;
            }

            return Cuit.Crear(prefijo, dni, sufijo);
        }
    }
}
