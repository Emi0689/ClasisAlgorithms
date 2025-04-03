using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SearchAndShort
{
    public class Short
    {
        static public int[] OrderByBurbujeo(int[] elemAOrdenar)
        {
            try
            {
                for (int i = 0; i < elemAOrdenar.Length; i++)
                {
                    for (int j = 0; j < elemAOrdenar.Length; j++)
                    {
                        if (elemAOrdenar[i] < elemAOrdenar[j])
                        {
                            int elemAux = elemAOrdenar[i];
                            elemAOrdenar[i] = elemAOrdenar[j];
                            elemAOrdenar[j] = elemAux;
                        }
                    }
                }
                return elemAOrdenar;
                throw new ApplicationException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Explotó");
                const int[] V = null;
                return V;
            }

        }
    }
}
