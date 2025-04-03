using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsUtilitys
{
    public class Duplicates
    {
        static public int DuplicatesV1(int[] arr, int k)
        {
            int min = 0;
            for (int i = 1; i < (arr[0]+1); i++)
            {
                min += arr[i];
            }
            min /= k;
            if (min % k != 0)
            {
                min++;
            }
            return min;
        }


    }
}
