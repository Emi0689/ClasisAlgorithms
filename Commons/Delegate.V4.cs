using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public partial class Delegate
    {
        public static void RunV4()
        {
            FindBiggerNum delegateNum = f => f.OrderByDescending(x => x).First();

            //or

            static int delegateNum2(List<int> f) => f.OrderByDescending(x => x).First();

            var list = new List<int> { 1, 2, 3, 400 };
            var result = delegateNum(list);

            Console.WriteLine(result);
        }
    }
}
