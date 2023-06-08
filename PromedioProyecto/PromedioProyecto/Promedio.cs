using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    internal class Promedio
    {
        public double acum = 0;
        public int contador = 0;

        public Promedio(){}
        public void AgregarValor(double valor)
        {
            acum += valor;
            contador++;
        }

        public double CalcularPromedio()
        {
            double promedio = 0;

            if (contador > 0)
            {
                promedio = acum / contador;
            }

            return promedio;
        }

    }
}
