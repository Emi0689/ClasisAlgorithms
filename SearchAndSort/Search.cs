using System;
using System.Linq;

namespace SearchAndShort
{
    public class Search
    {
        private static int[] QuickShort(int[] elemAOrdenar)
        {
            try
            {
                if (elemAOrdenar.Count() == 0)
                    return elemAOrdenar; //return empty

                int[] ListaIzquierda = null;
                int[] ListaDerecha = null;
                int pivote = elemAOrdenar.First();

                for (int i = 0; i < elemAOrdenar.Length; i++)
                {
                    if (elemAOrdenar[i] < pivote)
                        ListaIzquierda.Append(elemAOrdenar[i]);
                    else if (elemAOrdenar[i] > pivote)
                        ListaDerecha.Append(elemAOrdenar[i]);
                }

                return QuickShort((int[])ListaIzquierda.Append(pivote).Concat(ListaDerecha));
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
