using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float masa, exMasa;
            float cantBudin, cantCajas, cantPaqt;

            Console.WriteLine("Ingrese cuantos kilos utilizara: ");
            masa = float.Parse(Console.ReadLine());

            masa = masa * 1000;
            cantBudin = (masa / 55);
            exMasa = masa / (cantBudin * 55);
            cantPaqt = (cantBudin / 12);
            cantCajas = (cantBudin / 20);

            Console.WriteLine($"Con {masa/1000} kg de masa se pueden preparar: ");
            Console.WriteLine($"{cantBudin} budines de 55gr");
            Console.WriteLine($"{cantPaqt} paquetes de 12 budines");
            Console.WriteLine($"{cantCajas} cajas de 20 paquetes");
            Console.WriteLine($"Y sobran {exMasa} gr de masa ({exMasa/1000}kggit)");
        }
    }
}
