using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public static class Yield
    {
        public static IEnumerable<int> getNumber()
        {
            List<int> myList = new List<int> { -1, -4, 3, 5 };

            foreach (var num in myList)
            {
                if (num >= 0)
                {
                    //myList.Add(num);
                    yield return num;
                    Console.WriteLine("OPAAA");
                }
            }
        }
        public static void MainYeild()
        {
            foreach (var items in getNumber())
            {
                Console.WriteLine(items);
            }
        }
    }
    
}
