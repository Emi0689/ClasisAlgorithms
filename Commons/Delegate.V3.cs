using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generic.Delegate;

namespace Generic
{
    public partial class Delegate
    {
        public static void RunV3()
        {
            FindBiggerNum delegateNum = delegate (List<int> list)
            {
                return list.OrderByDescending(x => x).First();
            };

            var list = new List<int> { 1, 2, 3, 400 };
            var result = delegateNum(list);

            Console.WriteLine(result);
        }
    }
}
