using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosWhileFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //For
            //Parte 1 valor de la iteracion
            //Parte2 condicion
            //Parte 3 aumento o decremento

            int tabla;
            int i = 1; //parte 1

            Console.WriteLine("Ingrese el número de la tabla que quiere calcular: ");
            tabla = int.Parse(Console.ReadLine());

            //Parte 2
            while (i <= 10)
            {
                Console.WriteLine("" + tabla * i);
                i++; //parte 3
            }


            Console.ReadKey();

        }
    }
}