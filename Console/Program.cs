﻿using SearchAndShort;
using StringLibrary;
using System;
using System.Linq;

namespace ProgramasClasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add a list of element separated by comas: \n\r");
            string paraOrdenar = Console.ReadLine();
            string[] listaAOrdenar = paraOrdenar.Trim().Split(",");
            int[] elemAOrdenar = listaAOrdenar.Select(x => Convert.ToInt32(x)).ToArray();
            StringSmart.PrintString(Sort.OrderByBubbleSort(elemAOrdenar));
            Console.ReadLine();
        }
    }
}
