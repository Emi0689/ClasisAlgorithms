using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public partial class Delegate
    {
        public delegate int FindBiggerNum(List<int> lst);
        
        public static void RunV1()
        {
            FindBiggerNum delegadoNum = FindBiggerNumFunc;

            var list = new List<int> { 1, 2, 3, 400 };
            var result = delegadoNum(list);

            Console.WriteLine(result);
        }

        public static int FindBiggerNumFunc(List<int> lst)
        {
            return lst.OrderByDescending(x => x).First();
        }
        
    }
}
