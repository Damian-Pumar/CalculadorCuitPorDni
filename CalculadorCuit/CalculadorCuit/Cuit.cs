using System;

namespace CalculadorCuit
{
    public class Cuit
    {
        private const String cuitFormat = "{0}-{1}-{2}";

        private Cuit(Int32 prefijo, Dni dni, Int32 sufijo)
        {
            this.Prefijo = prefijo;

            this.Dni = dni;

            this.Sufijo = sufijo;
        }

        public Int32 Prefijo { get; private set; }

        public Dni Dni { get; private set; }

        public Int32 Sufijo { get; private set; }

        public String ValorCompleto
        {
            get
            {
                return String.Format(cuitFormat, this.Prefijo, this.Dni.Numero, this.Sufijo);
            }
        }

        public static Cuit Crear(Int32 prefijo, Dni dni, Int32 sufijo)
        {
            return new Cuit(prefijo, dni, sufijo);
        }
    }
}
