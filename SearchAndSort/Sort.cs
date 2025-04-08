using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SearchAndShort
{
    public class Sort
    {
        static public int[] OrderByBubbleSort(int[] elemToSort)
        {
            try
            {
                for (int i = 0; i < elemToSort.Length; i++)
                {
                    for (int j = 0; j < elemToSort.Length; j++)
                    {
                        if (elemToSort[i] < elemToSort[j])
                        {
                            int elemAux = elemToSort[i];
                            elemToSort[i] = elemToSort[j];
                            elemToSort[j] = elemAux;
                        }
                    }
                }
                return elemToSort;
            }
            catch (Exception ex)
            {
                Console.WriteLine("oh no!");
                const int[] V = null;
                return V;
            }

        }
    }
}
