using System;

namespace CalculadorCuit
{
    public class Dni
    {
        private Dni(Int32 numero, Persona persona)
        {
            this.Numero = numero;

            this.Persona = persona;
        }

        public Int32 Numero { get; private set; }

        public Persona Persona { get; private set; }

        public Int32 CalcularValorInicializador()
        {
            var dni = this.ToChar();

            var resultado = ((dni[0] - '0') * 3)
                         + ((dni[1] - '0') * 2)
                         + ((dni[2] - '0') * 7)
                         + ((dni[3] - '0') * 6)
                         + ((dni[4] - '0') * 5)
                         + ((dni[5] - '0') * 4)
                         + ((dni[6] - '0') * 3)
                         + ((dni[7] - '0') * 2);

            return resultado;
        }

        private Char[] ToChar()
        {
            return this.Numero.ToString().ToCharArray();
        }

        public static Dni Crear(Int32 numero, Persona persona)
        {
            return new Dni(numero, persona);
        }
    }
}
