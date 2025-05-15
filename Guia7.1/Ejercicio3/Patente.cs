using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
           

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            int alta = num / 1000;
            int baja = num % 1000;

            int d1 = alta / (26*26);
            int d2 = alta % (26 * 26) / 26;
            int d3 = alta % (26*26)% 26;

            char dc1 = (char)(d1 + 65);
            char dc2 = (char)(d2 + 65);
            char dc3 = (char)(d3 + 65);

            int d4 = baja / 100;
            int d5 = baja % 100 / 10;
            int d6 = baja % 100 % 10;

            char dc4 = (char)(d4 + 48);
            char dc5 = (char)(d5 + 48);
            char dc6 = (char)(d6 + 48);


            Console.WriteLine(""+dc1+dc2+dc3+dc4+dc5+dc6);
        }
    }
}
