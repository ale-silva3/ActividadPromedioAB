using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int opcion;

            Promedio myPromedio = new Promedio();

            do 
            {
                Console.WriteLine("1. Ingresar Numero");
                Console.WriteLine("2. Mostrar Promedio");
                Console.WriteLine("3. Salir ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero o -1 para salir");
                        valor = Convert.ToDouble(Console.ReadLine());

                        while(valor >= 0)
                        {
                            myPromedio.AgregarValor(valor);
                            Console.WriteLine("Ingrese un numero o -1 para salir");
                            valor = Convert.ToDouble(Console.ReadLine());
                        }
                        break;

                    case 2:
                        Console.WriteLine("Promedio: {0}",myPromedio.CalcularPromedio());
                        Console.ReadKey();
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            } 
            while (opcion != 3);

        }
    }
}
