using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edadAP, edadL, edadM, edadJ, sumEdad;
            float ingreso, mensAP, mensL, mensM, mensJ;

            Console.WriteLine("Ingrese la edad de Ana Paula, Lucia, Milena y Jazmin");
            edadAP = int.Parse(Console.ReadLine());
            edadL = int.Parse(Console.ReadLine());
            edadM = int.Parse(Console.ReadLine());
            edadJ = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cuanto le ingresa a la abuela");
            ingreso = float.Parse(Console.ReadLine());

            sumEdad = edadAP + edadL + edadM + edadJ;
            mensAP = (float)edadAP / sumEdad * ingreso;
            mensL = (float)edadL / sumEdad * ingreso;
            mensM = (float)edadM / sumEdad * ingreso;
            mensJ = (float)edadJ / sumEdad * ingreso;

            Console.WriteLine($"La mensualidad de Ana Paula es: ${mensAP}");
            Console.WriteLine($"La mensualidad de Lucia es: ${mensL}");
            Console.WriteLine($"La mensualidad de Milena es: ${mensM}");
            Console.WriteLine($"La mensualidad de Jazmin es: ${mensJ}");

        }
    }
}
