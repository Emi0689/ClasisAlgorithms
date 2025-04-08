using SearchAndShort;
using StringLibrary;
using System;
using System.Linq;

namespace ProgramasClasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese una lista de números separados por comas: \n\r");
            string paraOrdenar = Console.ReadLine();
            string[] listaAOrdenar = paraOrdenar.Trim().Split(",");
            int[] elemAOrdenar = listaAOrdenar.Select(x => Convert.ToInt32(x)).ToArray();
            StringSmart.printString(Short.OrderByBurbujeo(elemAOrdenar));
            Console.ReadLine();
        }
    }
}
